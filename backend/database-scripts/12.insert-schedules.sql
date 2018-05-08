USE [AdvantageDB]
GO

-- bcd travel

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'12:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 13)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 14)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 15)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 16)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 17)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 18)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 19)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 20)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 21)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 22)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (17, 23)

-- los castores

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, CAST(N'07:45:00' AS Time), CAST(N'13:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 24)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 25)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 26)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 27)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 28)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 29)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES ( 18, 30)

-- La Ciacruz

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 31)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 32)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 33)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 34)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 35)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 36)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 37)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 38)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 39)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (19, 40)

-- Clementina

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 41)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 42)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 43)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 44)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 45)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (20, 46)

-- Comtecto

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 47)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 48)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 49)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 50)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 51)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 52)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 53)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 54)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 55)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (21, 56)

-- El cortijo

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'17:00:00' AS Time), CAST(N'02:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'17:00:00' AS Time), CAST(N'02:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'17:00:00' AS Time), CAST(N'02:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 57)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 58)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 59)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 60)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 61)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 62)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (22, 63)

-- Crazy Store

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'10:00:00' AS Time), CAST(N'16:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 64)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 65)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 66)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 67)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 68)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (23, 69)

-- Dismac

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'19:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 70)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 71)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 72)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 73)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 74)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (24, 75)

-- Eskaparate

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:30:00' AS Time), CAST(N'12:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:30:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'15:00:00' AS Time), CAST(N'19:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 76)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 77)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 78)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 79)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 80)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 81)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 82)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 83)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 84)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 85)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 86)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (25, 87)

-- Factory

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'00:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 88)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 89)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 90)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 91)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 92)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (26, 93)

-- Full office

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 94)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 95)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 96)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 97)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 98)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 99)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 100)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 101)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 102)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (27, 103)

-- Go2Sports

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'16:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'16:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'16:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'16:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'16:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'13:00:00' AS Time), CAST(N'18:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 104)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 105)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 106)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 107)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 108)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (28, 109)

-- Home Center

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'08:30:00' AS Time), CAST(N'21:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 110)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 111)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 112)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 113)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 114)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (29, 115)

-- Hotel Cochabamba

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 116)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 117)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 118)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 119)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 120)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 121)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (30, 122)

-- Hotel La Colonia

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, CAST(N'00:00:00' AS Time), CAST(N'23:59:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 123)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 124)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 125)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 126)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 127)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 128)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (31, 129)

-- Julyios

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 130)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 131)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 132)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 133)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 134)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (1, 135)

-- Kafalu

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'20:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 136)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 137)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 138)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 139)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 140)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (2, 141)

-- Libreria Josue

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 142)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 143)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 144)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 145)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 146)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (3, 147)

-- Milaneza Club

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 148)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 149)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 150)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 151)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 152)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (4, 153)

-- Muela del diablo

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 154)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 155)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 156)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 157)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 158)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (5, 159)

-- Patata Brava

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'19:00:00' AS Time), CAST(N'22:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 160)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 161)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 162)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 163)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 164)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (6, 165)

-- Petra Online

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'21:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 166)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 167)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 168)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 169)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 170)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (7, 171)

-- Pil Andina

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'08:00:00' AS Time), CAST(N'20:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 172)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 173)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 174)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 175)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 176)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (8, 177)

-- Rubsor Automotors

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'14:30:00' AS Time), CAST(N'18:30:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 178)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 179)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 180)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 181)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 182)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 183)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 184)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 185)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 186)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (9, 187)

-- Puerto Natura

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 188)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 189)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 190)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 191)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 192)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (10, 193)

-- Spicy

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 194)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 195)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 196)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 197)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 198)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (11, 199)

-- Tonnys Burguer

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'21:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 200)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 201)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 202)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 203)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 204)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (12, 205)

-- Top Collection

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 206)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 207)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 208)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 209)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 210)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (13, 211)

-- Totto

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'09:00:00' AS Time), CAST(N'20:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 212)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 213)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 214)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 215)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 216)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (14, 217)

-- Wistupiku

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'07:30:00' AS Time), CAST(N'20:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 218)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 219)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 220)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 221)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 222)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 223)

-- Zona de humor

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time))

INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 224)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 225)
INSERT [dbo].[PromoterSchedules] ( [PromoterId], [ScheduleId]) VALUES (15, 226)

INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (2, 11)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (2, 12)