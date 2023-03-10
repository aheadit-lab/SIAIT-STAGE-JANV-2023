USE [SIAITBDD]
GO
/****** Object:  Table [dbo].[Action]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Action](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Code] [varchar](255) NOT NULL,
	[URLS] [varchar](1024) NOT NULL,
	[Mandatory] [int] NOT NULL,
	[MENU_ID] [int] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Career]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Career](
	[ID] [int] NOT NULL,
	[CIVIL_STATUS_ID] [int] NOT NULL,
	[CATEGORY_ID] [int] NOT NULL,
	[Grade_id] [int] NOT NULL,
	[Qualification_id] [int] NOT NULL,
	[Collaborator_id] [int] NOT NULL,
	[HOUSE_HOLDER] [int] NOT NULL,
	[SALARY] [float] NOT NULL,
	[BBAN] [varchar](255) NOT NULL,
	[NUMBER_OF_CHILDREN] [int] NOT NULL,
	[FROM] [date] NOT NULL,
	[TO] [date] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Code] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Civil_status]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Civil_status](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Code] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[collaborator]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[collaborator](
	[ID] [int] NOT NULL,
	[REGISTRATION_NUMBER] [varchar](255) NOT NULL,
	[FIRST_NAME] [varchar](255) NOT NULL,
	[LAST_NAME] [varchar](255) NOT NULL,
	[EMAIL] [varchar](255) NOT NULL,
	[PHONE_NUMBER] [varchar](255) NOT NULL,
	[CIN] [varchar](255) NOT NULL,
	[CNSS] [varchar](255) NOT NULL,
	[BIRTH_DATE] [date] NOT NULL,
	[SEX] [varchar](255) NOT NULL,
	[CIVIL_STATUS_ID] [int] NOT NULL,
	[HIRING_DATE] [date] NOT NULL,
	[SALARY] [float] NOT NULL,
	[BBAN] [varchar](255) NOT NULL,
	[LEAVES_BALANCE] [float] NOT NULL,
	[LEAVES_BALANCE_DATE] [date] NOT NULL,
	[NUMBER_OF_CHILDREN] [int] NOT NULL,
	[HOUSE_HOLDER] [int] NOT NULL,
	[CATEGORY_ID] [int] NOT NULL,
	[GRADE_ID] [int] NOT NULL,
	[QUALIFICATION_ID] [int] NOT NULL,
	[USER_ID] [int] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[ID] [int] NOT NULL,
	[NAME] [varchar](255) NOT NULL,
	[TAX_REGISTRATION_NUMBER] [varchar](255) NOT NULL,
	[TRADE_REGISTER] [varchar](255) NOT NULL,
	[EXPLOITATION_CODE] [varchar](255) NOT NULL,
	[ADDRESS] [varchar](255) NOT NULL,
	[EMPLOYER_CODE] [varchar](255) NOT NULL,
	[SOCIAL_SECURITY_SCHEME] [varchar](255) NOT NULL,
	[CREATED_AT] [datetime] NOT NULL,
	[UPDATED_AT] [datetime] NOT NULL,
	[RNE] [varchar](255) NOT NULL,
	[EMAIL] [varchar](255) NOT NULL,
	[Telephone] [varchar](255) NOT NULL,
	[CREATION_DATE] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Code] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] NOT NULL,
	[TITLE] [varchar](255) NOT NULL,
	[PATH] [varchar](255) NOT NULL,
	[ICON] [varchar](255) NOT NULL,
	[CLASS] [varchar](255) NOT NULL,
	[Module_ID] [int] NOT NULL,
	[ONLY_SUPER_USER] [int] NOT NULL,
	[Order] [int] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODULE]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODULE](
	[ID] [int] NOT NULL,
	[TITLE] [varchar](255) NOT NULL,
	[PATH] [varchar](255) NOT NULL,
	[ICON] [varchar](255) NOT NULL,
	[CLASS] [varchar](255) NOT NULL,
	[ACTIVE] [int] NOT NULL,
	[ONLY_SUPER_USER] [int] NOT NULL,
	[Order] [int] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROFIL]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROFIL](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[code] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROFIL_ACTION]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROFIL_ACTION](
	[ID] [int] NOT NULL,
	[Profil_ID] [int] NOT NULL,
	[Action_ID] [int] NOT NULL,
	[Options] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profil_Menu]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profil_Menu](
	[ID] [int] NOT NULL,
	[PROFIL_ID] [int] NOT NULL,
	[MENU_ID] [int] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project](
	[ID] [int] NOT NULL,
	[NAME] [varchar](255) NOT NULL,
	[NUMBER_OF_DAYS] [float] NOT NULL,
	[MANAGER_ID] [int] NOT NULL,
	[CREATED_AT] [datetime] NOT NULL,
	[UPDATED_AT] [datetime] NOT NULL,
	[START_DATE] [date] NOT NULL,
	[END_DATE] [date] NOT NULL,
	[ACTIVE] [int] NOT NULL,
	[CLIENT_ID] [int] NOT NULL,
	[CONSUMED_DAYS] [float] NOT NULL,
	[EXTERN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qualification]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qualification](
	[ID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Code] [varchar](255) NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/02/2023 16:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] NOT NULL,
	[CIVIL_STATUS_ID] [int] NOT NULL,
	[CATEGORY_ID] [int] NOT NULL,
	[Grade_id] [int] NOT NULL,
	[Qualification_id] [int] NOT NULL,
	[Collaborator_id] [int] NOT NULL,
	[HOUSE_HOLDER] [int] NOT NULL,
	[SALARY] [float] NOT NULL,
	[BBAN] [varchar](255) NOT NULL,
	[NUMBER_OF_CHILDREN] [int] NOT NULL,
	[FROM] [date] NOT NULL,
	[TO] [date] NOT NULL,
	[Created_AT] [datetime] NOT NULL,
	[Updated_AT] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Grade] ([ID], [Name], [Code], [Created_AT], [Updated_AT]) VALUES (1, N'C1', N'C1', CAST(N'2023-01-22T00:00:00.000' AS DateTime), CAST(N'2023-01-22T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[Career]  WITH CHECK ADD  CONSTRAINT [fk_career_categ] FOREIGN KEY([CIVIL_STATUS_ID])
REFERENCES [dbo].[Civil_status] ([ID])
GO
ALTER TABLE [dbo].[Career] CHECK CONSTRAINT [fk_career_categ]
GO
ALTER TABLE [dbo].[Career]  WITH CHECK ADD  CONSTRAINT [fk_career_civil_status] FOREIGN KEY([CATEGORY_ID])
REFERENCES [dbo].[category] ([ID])
GO
ALTER TABLE [dbo].[Career] CHECK CONSTRAINT [fk_career_civil_status]
GO
ALTER TABLE [dbo].[Career]  WITH CHECK ADD  CONSTRAINT [fk_career_collaborator] FOREIGN KEY([Collaborator_id])
REFERENCES [dbo].[collaborator] ([ID])
GO
ALTER TABLE [dbo].[Career] CHECK CONSTRAINT [fk_career_collaborator]
GO
ALTER TABLE [dbo].[Career]  WITH CHECK ADD  CONSTRAINT [fk_career_grade] FOREIGN KEY([Grade_id])
REFERENCES [dbo].[Grade] ([ID])
GO
ALTER TABLE [dbo].[Career] CHECK CONSTRAINT [fk_career_grade]
GO
ALTER TABLE [dbo].[Career]  WITH CHECK ADD  CONSTRAINT [fk_career_qualification] FOREIGN KEY([Qualification_id])
REFERENCES [dbo].[Qualification] ([ID])
GO
ALTER TABLE [dbo].[Career] CHECK CONSTRAINT [fk_career_qualification]
GO
ALTER TABLE [dbo].[collaborator]  WITH CHECK ADD  CONSTRAINT [fk_collaborator_category] FOREIGN KEY([CATEGORY_ID])
REFERENCES [dbo].[category] ([ID])
GO
ALTER TABLE [dbo].[collaborator] CHECK CONSTRAINT [fk_collaborator_category]
GO
ALTER TABLE [dbo].[collaborator]  WITH CHECK ADD  CONSTRAINT [fk_collaborator_CIVIL_STATUS] FOREIGN KEY([CIVIL_STATUS_ID])
REFERENCES [dbo].[Civil_status] ([ID])
GO
ALTER TABLE [dbo].[collaborator] CHECK CONSTRAINT [fk_collaborator_CIVIL_STATUS]
GO
ALTER TABLE [dbo].[collaborator]  WITH CHECK ADD  CONSTRAINT [fk_collaborator_grade] FOREIGN KEY([GRADE_ID])
REFERENCES [dbo].[Grade] ([ID])
GO
ALTER TABLE [dbo].[collaborator] CHECK CONSTRAINT [fk_collaborator_grade]
GO
ALTER TABLE [dbo].[collaborator]  WITH CHECK ADD  CONSTRAINT [fk_collaborator_qualification] FOREIGN KEY([QUALIFICATION_ID])
REFERENCES [dbo].[Qualification] ([ID])
GO
ALTER TABLE [dbo].[collaborator] CHECK CONSTRAINT [fk_collaborator_qualification]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [fk_menu_module_id] FOREIGN KEY([Module_ID])
REFERENCES [dbo].[MODULE] ([ID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [fk_menu_module_id]
GO
ALTER TABLE [dbo].[PROFIL_ACTION]  WITH CHECK ADD  CONSTRAINT [fk_profil_action_action_id] FOREIGN KEY([Action_ID])
REFERENCES [dbo].[Action] ([ID])
GO
ALTER TABLE [dbo].[PROFIL_ACTION] CHECK CONSTRAINT [fk_profil_action_action_id]
GO
ALTER TABLE [dbo].[PROFIL_ACTION]  WITH CHECK ADD  CONSTRAINT [fk_profil_action_profil_id] FOREIGN KEY([Profil_ID])
REFERENCES [dbo].[PROFIL] ([ID])
GO
ALTER TABLE [dbo].[PROFIL_ACTION] CHECK CONSTRAINT [fk_profil_action_profil_id]
GO
ALTER TABLE [dbo].[Profil_Menu]  WITH CHECK ADD  CONSTRAINT [fk_prodil_menu_profil_id] FOREIGN KEY([PROFIL_ID])
REFERENCES [dbo].[PROFIL] ([ID])
GO
ALTER TABLE [dbo].[Profil_Menu] CHECK CONSTRAINT [fk_prodil_menu_profil_id]
GO
ALTER TABLE [dbo].[Profil_Menu]  WITH CHECK ADD  CONSTRAINT [fk_profuil_menu_menu_id] FOREIGN KEY([MENU_ID])
REFERENCES [dbo].[Menu] ([ID])
GO
ALTER TABLE [dbo].[Profil_Menu] CHECK CONSTRAINT [fk_profuil_menu_menu_id]
GO
ALTER TABLE [dbo].[project]  WITH CHECK ADD  CONSTRAINT [FK_PROJECT_MANAGER_ID__COLLABORATOR_ID] FOREIGN KEY([MANAGER_ID])
REFERENCES [dbo].[collaborator] ([ID])
GO
ALTER TABLE [dbo].[project] CHECK CONSTRAINT [FK_PROJECT_MANAGER_ID__COLLABORATOR_ID]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_career_categ_user] FOREIGN KEY([CIVIL_STATUS_ID])
REFERENCES [dbo].[Civil_status] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_career_categ_user]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_career_civil_status_user] FOREIGN KEY([CATEGORY_ID])
REFERENCES [dbo].[category] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_career_civil_status_user]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_career_collaborator_user] FOREIGN KEY([Collaborator_id])
REFERENCES [dbo].[collaborator] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_career_collaborator_user]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_career_grade_user] FOREIGN KEY([Grade_id])
REFERENCES [dbo].[Grade] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_career_grade_user]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_career_qualification_user] FOREIGN KEY([Qualification_id])
REFERENCES [dbo].[Qualification] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_career_qualification_user]
GO
