USE [HMS]
GO
/****** Object:  Table [dbo].[bed]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bed](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ward] [int] NULL,
	[number_bed] [int] NULL,
	[status] [bit] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[total_money] [int] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detail_patient]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_patient] [int] NULL,
	[id_staff] [int] NULL,
	[id_bill] [int] NULL,
	[id_bed] [int] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[end_time] [date] NULL,
	[start_time] [date] NULL,
	[pathological] [nvarchar](1000) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detail_patient] [int] NULL,
	[id_medicine] [int] NULL,
	[quantity] [int] NULL,
	[time_of_days] [nvarchar](50) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine_product]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine_product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[medicine_name] [nvarchar](100) NULL,
	[cost] [float] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 12/28/2020 2:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[health_insurance_number] [nvarchar](50) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[sex] [nvarchar](5) NULL,
	[phone_number] [text] NULL,
	[birthday] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[full_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[sex] [nvarchar](3) NULL,
	[date_join] [datetime] NULL,
	[time_for_work] [nvarchar](30) NULL,
	[department] [nvarchar](10) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[phone_number] [text] NULL,
	[birthday] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detail_patient] [int] NULL,
	[id_test] [int] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test_product]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[test_name] [nvarchar](100) NULL,
	[cost] [float] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ward]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ward](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name_ward] [nvarchar](50) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bed]  WITH CHECK ADD  CONSTRAINT [FK_bed_ward] FOREIGN KEY([id_ward])
REFERENCES [dbo].[ward] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bed] CHECK CONSTRAINT [FK_bed_ward]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_bed] FOREIGN KEY([id_bed])
REFERENCES [dbo].[bed] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_bed]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_bill] FOREIGN KEY([id_bill])
REFERENCES [dbo].[bill] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_bill]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_patient]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_staff] FOREIGN KEY([id_staff])
REFERENCES [dbo].[staff] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_staff]
GO
ALTER TABLE [dbo].[medicine]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_medicine] FOREIGN KEY([id_detail_patient])
REFERENCES [dbo].[detail_patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[medicine] CHECK CONSTRAINT [FK_detail_patient_medicine]
GO
ALTER TABLE [dbo].[medicine]  WITH CHECK ADD  CONSTRAINT [FK_medicine_medicine_product] FOREIGN KEY([id_medicine])
REFERENCES [dbo].[medicine_product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[medicine] CHECK CONSTRAINT [FK_medicine_medicine_product]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_test] FOREIGN KEY([id_detail_patient])
REFERENCES [dbo].[detail_patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_detail_patient_test]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_test_test_product] FOREIGN KEY([id_test])
REFERENCES [dbo].[test_product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_test_test_product]
GO
/****** Object:  StoredProcedure [dbo].[USP_CreatePatient]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CreatePatient] @fname nvarchar(50), @birthday date, @address nvarchar(100), @phoneno text , @sex nvarchar(10), @hin nvarchar(50)
AS
INSERT INTO dbo.patient
(
    full_name,
    birthday,
    address,
    phone_number,
    sex,
    health_insurance_number,
    create_at,
    update_at
)
OUTPUT Inserted.id
VALUES
(   @fname,       -- full_name - nvarchar(100)
    @birthday, -- birthday - datetime
    @address,       -- address - nvarchar(100)
    @phoneno,         -- phone_number - int
    @sex,       -- sex - nvarchar(3)
    @hin,       -- health_insurance_number - nvarchar(50)
    GETDATE(), -- create_at - datetime
    GETDATE()  -- update_at - datetime
	)
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertStaff]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertStaff](@email nvarchar(100), @pwd nvarchar(100), @fname nvarchar(100), @address nvarchar(150), @phoneno text, @birthday date, @timeforwork nvarchar(50), @department NVARCHAR(15), @sex NVARCHAR(5))
as
INSERT INTO dbo.staff
(
    email,
    password,
    full_name,
    birthday,
    address,
    phone_number,
    sex,
    date_join,
    time_for_work,
    department,
    create_at,
    update_at
)
VALUES
(   @email,       -- email - nvarchar(50)
    @pwd,       -- password - nvarchar(50)
    @fname,       -- full_name - nvarchar(100)
    @birthday, -- birthday - datetime
    @address,       -- address - nvarchar(100)
    @phoneno,         -- phone_number - int
    @sex,       -- sex - nvarchar(3)
    GETDATE(), -- date_join - datetime
    @timeforwork,       -- time_for_work - nvarchar(30)
    @department,       -- department - nvarchar(10)
    GETDATE(), -- create_at - datetime
    GETDATE()  -- update_at - datetime
    )
GO
/****** Object:  StoredProcedure [dbo].[USP_PatientReportByTime]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_PatientReportByTime](@begin DATE, @end DATE)
AS
BEGIN
SELECT dbo.patient.full_name, dbo.patient.address,dbo.patient.phone_number, dbo.patient.sex, dbo.patient.birthday, dbo.detail_patient.start_time, dbo.detail_patient.end_time FROM dbo.detail_patient INNER JOIN dbo.patient ON patient.id = detail_patient.id_patient WHERE start_time BETWEEN @begin AND @end
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ReportPatient]    Script Date: 12/28/2020 2:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ReportPatient](@day int)
AS
BEGIN
    SELECT dbo.patient.full_name,patient.address, dbo.patient.phone_number, dbo.patient.sex, dbo.detail_patient.start_time 
	FROM dbo.detail_patient INNER JOIN dbo.patient 
		ON patient.id = detail_patient.id_patient 
		WHERE DATEDIFF(DAY, dbo.detail_patient.start_time, GETDATE()) >= @day
END
GO
