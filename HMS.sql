USE [HMS]
GO
/****** Object:  Table [dbo].[bed]    Script Date: 12/18/2020 2:14:37 AM ******/
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
/****** Object:  Table [dbo].[bill]    Script Date: 12/18/2020 2:14:37 AM ******/
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
/****** Object:  Table [dbo].[detail_patient]    Script Date: 12/18/2020 2:14:37 AM ******/
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
	[start_time] [datetime] NULL,
	[end_time] [datetime] NULL,
	[check_out] [bit] NULL,
	[hospitalization_status] [bit] NULL,
	[status] [bit] NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine]    Script Date: 12/18/2020 2:14:37 AM ******/
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
/****** Object:  Table [dbo].[medicine_product]    Script Date: 12/18/2020 2:14:37 AM ******/
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
/****** Object:  Table [dbo].[patient]    Script Date: 12/18/2020 2:14:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](100) NULL,
	[birthday] [datetime] NULL,
	[address] [nvarchar](100) NULL,
	[phone_number] [int] NULL,
	[health_insurance_number] [nvarchar](50) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[pathological] [nvarchar](1000) NULL,
	[status] [bit] NULL,
	[sex] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 12/18/2020 2:14:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[full_name] [nvarchar](100) NULL,
	[birthday] [datetime] NULL,
	[address] [nvarchar](100) NULL,
	[phone_number] [int] NULL,
	[sex] [nvarchar](3) NULL,
	[date_join] [datetime] NULL,
	[time_for_work] [nvarchar](30) NULL,
	[department] [nvarchar](10) NULL,
	[create_at] [datetime] NULL,
	[update_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 12/18/2020 2:14:38 AM ******/
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
/****** Object:  Table [dbo].[test_product]    Script Date: 12/18/2020 2:14:38 AM ******/
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
/****** Object:  Table [dbo].[ward]    Script Date: 12/18/2020 2:14:38 AM ******/
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
GO
ALTER TABLE [dbo].[bed] CHECK CONSTRAINT [FK_bed_ward]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_bed] FOREIGN KEY([id_bed])
REFERENCES [dbo].[bed] ([id])
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_bed]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_bill] FOREIGN KEY([id_bill])
REFERENCES [dbo].[bill] ([id])
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_bill]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[patient] ([id])
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_patient]
GO
ALTER TABLE [dbo].[detail_patient]  WITH CHECK ADD  CONSTRAINT [FK_detail_patient_staff] FOREIGN KEY([id_staff])
REFERENCES [dbo].[staff] ([id])
GO
ALTER TABLE [dbo].[detail_patient] CHECK CONSTRAINT [FK_detail_patient_staff]
GO
/****** Object:  StoredProcedure [dbo].[USP_CreatePatient]    Script Date: 12/18/2020 2:14:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CreatePatient] @fname nvarchar(50), @birthday date, @address nvarchar(100), @phoneno int , @sex nvarchar(10), @hin nvarchar(50)
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
    update_at,
	status
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
    GETDATE(),  -- update_at - datetime
    1
	)
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertStaff]    Script Date: 12/18/2020 2:14:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_InsertStaff](@email nvarchar(100), @pwd nvarchar(100), @fname nvarchar(100), @address nvarchar(150), @phoneno int, @birthday date, @timeforwork nvarchar(50), @department NVARCHAR(15), @sex NVARCHAR(5))
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
