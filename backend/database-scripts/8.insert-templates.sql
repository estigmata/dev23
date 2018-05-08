USE [AdvantageDB]
GO

INSERT [dbo].[Templates] ([Name]) VALUES (N'Office')
INSERT [dbo].[Templates] ([Name]) VALUES (N'Weekend')

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, N'08:00:00', N'12:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, N'08:00:00', N'12:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, N'08:00:00', N'12:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, N'08:00:00', N'12:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, N'08:00:00', N'12:00:00')

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (1, N'14:00:00', N'18:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (2, N'14:00:00', N'18:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (3, N'14:00:00', N'18:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (4, N'14:00:00', N'18:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (5, N'14:00:00', N'18:00:00')

INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (6, N'09:00:00', N'20:00:00')
INSERT [dbo].[Schedules] ([Day], [From], [To]) VALUES (7, N'09:00:00', N'20:00:00')

INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 1)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 2)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 3)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 4)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 5)

INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 6)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 7)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 8)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 9)
INSERT [dbo].[TemplateSchedules] ([TemplateId], [ScheduleId]) VALUES (1, 10)


