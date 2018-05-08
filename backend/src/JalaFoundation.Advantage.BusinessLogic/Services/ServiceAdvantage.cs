// <copyright file="ServiceAdvantage.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.BusinessLogic.DTO;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServiceBenefit class implements the methods to interact with the Data Access Project
    /// </summary>
    public class ServiceAdvantage : SingletonBase<ServiceAdvantage>, IAdvantage
    {
        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IBenefitRepository benefitRepository;

        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IScheduleRepository scheduleRepository;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceAdvantage"/> class from being created.
        /// Init an instance of BenefitRepository and assigns it to benefitRepository.
        /// Init an instance of ScheduleRepository and assigns it to scheduleRepository.
        /// </summary>
        private ServiceAdvantage() : base()
        {
            this.benefitRepository = RepositoryFactory.GetBenefitRepository();
            this.scheduleRepository = RepositoryFactory.GetScheduleRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAdvantage"/> class.
        /// </summary>
        /// <param name="benefitRepository">Receives the instance of IBenefitRepository</param>
        /// <param name="scheduleRepository">Receive the instance of IScheduleRepository</param>
        private ServiceAdvantage(IBenefitRepository benefitRepository, IScheduleRepository scheduleRepository) : base()
        {
            this.benefitRepository = benefitRepository;
            this.scheduleRepository = scheduleRepository;
        }

        /// <summary>
        /// Get the list of all advantages
        /// </summary>
        /// <returns>
        /// An AdvantagesListDTO object
        /// </returns>
        public AdvantagesListDTO GetAdvantagesList()
        {
            var benefits = this.benefitRepository.GetAllWithPromoters();

            if (benefits.Count == 0)
            {
                throw new EmptyAdvantageListException();
            }

            AdvantagesListDTO advantagesList = new AdvantagesListDTO()
            {
                Total = benefits.Count,
                Data = benefits.OrderByDescending(b => b.CreationDate).Select(b => new BenefitDTO
                {
                    Id = b.Id,
                    Name = b.Name,
                    Description = b.Description,
                    MainText = b.MainText,
                    Status = b.Status,
                    IsNew = this.IsNewBenefit(b),
                    Promoter = new PromoterDTO
                    {
                        Name = b.Promoter.Name,
                        Logo = b.Promoter.Image.ImageSerialized,
                        IsOpen = this.IsAttendingRightNow(b.Promoter.Id),
                        Tags = b.Promoter.PromoterTag.Select(o => o.Tag.Name).ToList(),
                        Category = b.Promoter.Category.Name
                    }
                }).ToList()
            };

            return advantagesList;
        }

        /// <summary>
        /// The method verify if a Benefit is New
        /// </summary>
        /// <param name="benefit">
        /// Is the benefit that will be verify if is new or not
        /// </param>
        /// <returns>
        /// Retuns true if is New benefit otherwise return
        /// </returns>
        public bool IsNewBenefit(Benefit benefit)
        {
            if (!benefit.Status)
            {
                return false;
            }

            DateTime today = DateTime.Today;
            DateTime referenceDay;

            if (benefit.Duration != null)
            {
                referenceDay = benefit.CreationDate.AddDays(benefit.Duration.Value);

                if (referenceDay >= today)
                {
                    return true;
                }

                return false;
            }

            referenceDay = benefit.CreationDate.AddDays(30);

            if (referenceDay >= today)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Count the benefits that are new
        /// </summary>
        /// <param name="categoryId">
        /// is the category that will be count the new benefits
        /// </param>
        /// <returns>
        /// Return the number of new promotions
        /// </returns>
        public int CountNewBenefits(int categoryId)
        {
            int count = 0;

            var benefits = this.GetBenefitsList(categoryId);

            foreach (var benefit in benefits)
            {
                if (this.IsNewBenefit(benefit))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Get the list of benefits of specific category
        /// </summary>
        /// <param name="categoryId">
        /// This is a specific category 
        /// </param>
        /// <returns>
        /// Return a list of Benefits 
        /// </returns>
        public IList<Benefit> GetBenefitsList(int categoryId)
        {
            var benefits = this.benefitRepository.GetBenefitsByCategory(categoryId);

            return benefits;
        }

        /// <summary>
        /// Get a Benefit object using his specific id parameter.
        /// </summary>
        /// <param name="id">
        /// The id parameter is a unique identifier for a benefit
        /// </param>
        /// <returns>return an Benefit based in his id</returns>
        public Benefit GetAdvantage(int id)
        {
            var benefit = this.benefitRepository.Get(id);

            if (benefit == null)
            {
                throw new NullAdvantageException();
            }

            return benefit;            
        }

        /// <summary>
        /// Get the list of all benefits of a specific category
        /// </summary>
        /// <param name="category"> 
        /// The param is the name of a category
        /// </param>
        /// <returns> 
        /// An AdvantagesListDTO object
        /// </returns>
        public AdvantagesListDTO GetBenefitsByCategory(string category)
        {
                AdvantagesListDTO benefits = this.GetAdvantagesList();

                var filterBenefits = new AdvantagesListDTO();

                filterBenefits.Data = benefits.Data.Where(p => p.Promoter.Category == category).ToList();
                filterBenefits.Total = filterBenefits.Data.Count;

                return filterBenefits;
        }

        /// <summary>
        /// Update the Model of a Benefit
        /// </summary>
        /// <param name="benefitId">
        /// The id of the benefit to be updated
        /// </param>
        /// <param name="newBenefit">
        /// The benefit with the new information
        /// </param>
        /// <returns>
        /// True if the benefit was updated sucesfully or False if not
        /// </returns>
        public bool UpdateBenefit(int benefitId, Benefit newBenefit)
        {
            try
            {
                return this.benefitRepository.Update(benefitId, newBenefit);
            }
            catch (ArgumentException)
            {
                throw new NullAdvantageException();
            }
        }

        /// <summary>
        /// Set the repository instance of a schedule used for this class
        /// </summary>
        /// <param name="scheduleRepository">
        /// An instance of IScheduleRepository to be set
        /// </param>
        public void SetScheduleRepository(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }

        /// <summary>
        /// Get the list of all benefits of a specific promoter
        /// </summary>
        /// <param name="promoterId">
        /// The param is the id of a promoter
        /// </param>
        /// <returns>
        /// Return a BenefitDTO list
        /// </returns>
        public List<BenefitDTO> GetBenefitByPromoter(int promoterId)
        {
            var benefitsDTO = new List<BenefitDTO>();
            var listBenefits = this.benefitRepository.GetBenefitsByPromoter(promoterId);
            foreach (var benefit in listBenefits)
            {
                benefitsDTO.Add(new BenefitDTO
                {
                    Id = benefit.Id,
                    Name = benefit.Name
                });
            }

            return benefitsDTO;
        }

        /// <summary>
        /// Delete a specific benefit by id
        /// </summary>
        /// <param name="id">
        /// The id of the benefit
        /// </param>
        /// <returns>
        /// A true if the benefit was deleted and false if the operation of delete is failed
        /// </returns>
        public bool DeleteBenefit(int id)
        {
            var result = this.benefitRepository.Delete(id);

            if (result == false)
            {
                throw new NullAdvantageException();
            }

            return result;
        }

        /// <summary>
        /// Return a text "Open now" if isAttending is true or
        /// "Closed now" if isAttending is false
        /// </summary>
        /// <param name="isAttending">
        /// The isAttending represent if the promoter is attending 
        /// </param>
        /// <returns>
        /// Return a message depending on the value of isAttending
        /// </returns>
        public string GetTextIsAttending(bool isAttending)
        {
            if (isAttending)
            {
                return "Open now";
            }

            return "Closed now";
        }

        /// <summary>
        /// Get a TimeSpan of a specific DateTime struct 
        /// </summary>
        /// <param name="dateToday">
        /// The dateToday parameter value type represents dates and times of today.
        /// </param>
        /// <returns>Return a TimeSpan of specific DateTime struct</returns>
        public TimeSpan GetTimeToDay(DateTime dateToday)
        {
            var hourToday = dateToday.Hour;
            var minuteToday = dateToday.Minute;
            var secondToday = dateToday.Second;

            return new TimeSpan(hourToday, minuteToday, secondToday);
        }

        /// <summary>
        /// Set the repository instance of a benefit used for this class
        /// </summary>
        /// <param name="benefitRepository">
        /// An instance of IBenefitRepository to be set
        /// </param>
        public void SetBenefitRepository(IBenefitRepository benefitRepository)
        {
            this.benefitRepository = benefitRepository;
        }
        
        /// <summary>
        /// Get a Schedule list with the specific Promoter ID and date time of to day.
        /// </summary>
        /// <param name="dateToday">
        /// The dateToday parameter value type represents dates and times of today.
        /// </param>
        /// <param name="id">
        /// The id parameter is a unique identifier for a Promoter
        /// </param>
        /// <returns>Return a list of schedule object</returns>
        private List<Schedule> GetListDateSchudule(DateTime dateToday, int id)
        {
            var scheduleList = this.scheduleRepository.GetListSchedule(id);
            var dayOfWeek = (Models.DayOfWeek)dateToday.DayOfWeek;

            return scheduleList.Where(d => d.Day == dayOfWeek).ToList();
        }

        /// <summary>
        /// Get the status and message that represent if the promoter 
        /// is open or close
        /// </summary>
        /// <param name="id">
        /// The id parameter is a unique identifier for a Promoter
        /// </param>
        /// <returns>
        /// A tuple that contains the status of the promoter and the message
        /// "Open now" if the status is true or "Closed now" if false
        /// </returns>
        private Tuple<bool, string> IsAttendingRightNow(int id)
        {
            var isAttending = false;
            var dateToday = DateTime.Now;
            var scheduleDayList = this.GetListDateSchudule(dateToday, id);
            var timeToday = this.GetTimeToDay(dateToday);
            foreach (var schedule in scheduleDayList)
            {
                if (schedule.From < timeToday && schedule.To > timeToday)
                {
                    isAttending |= true;
                }
            }

            var textIsAttending = this.GetTextIsAttending(isAttending);

            return new Tuple<bool, string>(isAttending, textIsAttending);
        }
    }
}
