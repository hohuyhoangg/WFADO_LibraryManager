CREATE DATABASE LibraryManager
GO

USE LibraryManager
GO

-- Tạo bảng Librarian
CREATE TABLE Librarian
(
	Id VARCHAR(6) PRIMARY KEY,
	FirstName NVARCHAR(20),
	LastName NVARCHAR(20),
	Birthday DATE,
	Sex NVARCHAR(5),
	SSN VARCHAR(12),
	Address NVARCHAR(100),
	PhoneNumber VARCHAR(15),
	Email NVARCHAR(30),
	StartDate  DATE,
	Salary  DECIMAL(19, 4),
	Status  BIT DEFAULT 1
)
GO


-- Tạo hàm để tự tăng ID
CREATE FUNCTION Func_NextId(@lastLibrarianId VARCHAR(6), @preFix VARCHAR(3), @size INT)
	RETURNS VARCHAR(6)
AS
	BEGIN
	    IF (@lastLibrarianId = '')
			SET @lastLibrarianId = @preFix + REPLICATE(0, @size - LEN(@preFix))
		DECLARE @num_nextLibrarianId INT ,@nextLibrarianId VARCHAR(6)
		SET @lastLibrarianId = LTRIM(RTRIM(@lastLibrarianId))
		SET @num_nextLibrarianId = REPLACE(@lastLibrarianId, @preFix,'') + 1
		SET @size = @size - LEN(@preFix)
		SET @nextLibrarianId = @preFix + REPLICATE(0, @size - LEN(@preFix))
		SET @nextLibrarianId = @preFix + RIGHT(REPLICATE(0, @size) + CONVERT(VARCHAR(MAX), @num_nextLibrarianId) ,@size)
		RETURN @nextLibrarianId
	END
GO

CREATE TRIGGER Trig_NextLibrarianId ON [dbo].[Librarian]
FOR INSERT
AS 
	BEGIN
	    DECLARE @lastLibrarianId VARCHAR(6)
		SET @lastLibrarianId = ( SELECT TOP 1 Id FROM dbo.Librarian 
												ORDER BY Id DESC)
		UPDATE dbo.Librarian SET Id = dbo.Func_NextId(@lastLibrarianId,'Lib',6) WHERE Id=''
	END
GO

-- Tạo bảng Member

CREATE TABLE Member
(
	Id VARCHAR(15) PRIMARY KEY,
	FirstName NVARCHAR(20),
	LastName NVARCHAR(20),
	Birthday DATE,
	Sex NVARCHAR(5),
	SSN VARCHAR(12),
	Address NVARCHAR(100),
	PhoneNumber VARCHAR(15),
	Email NVARCHAR(30),
	RegisterDate  DATE,
	Status  BIT DEFAULT 1
)
GO

CREATE FUNCTION Func_NextMemberId(@lastMemberId VARCHAR(10), @preFix VARCHAR(3), @size INT)
	RETURNS VARCHAR(10)
AS
	BEGIN
	    IF (@lastMemberId = '')
			SET @lastMemberId = @preFix + REPLICATE(0, @size - LEN(@preFix))
		DECLARE @num_nextMemberId INT ,@nextMemberId VARCHAR(10)
		SET @lastMemberId = LTRIM(RTRIM(@lastMemberId))
		SET @num_nextMemberId = REPLACE(@lastMemberId, @preFix,'') + 1
		SET @size = @size - LEN(@preFix)
		SET @nextMemberId = @preFix + REPLICATE(0, @size - LEN(@preFix))
		SET @nextMemberId = @preFix + RIGHT(REPLICATE(0, @size) + CONVERT(VARCHAR(MAX), @num_nextMemberId) ,@size)
		RETURN @nextMemberId
	END
GO
DROP FUNCTION dbo.Func_NextMemberId

CREATE TRIGGER Trig_NextMemberId ON [dbo].[Member]
FOR INSERT
AS 
	BEGIN
	    DECLARE @lastMemberId VARCHAR(10)
		SET @lastMemberId = ( SELECT TOP 1 Id FROM dbo.Member 
												ORDER BY Id DESC)
		UPDATE dbo.Member SET Id = dbo.Func_NextMemberId(@lastMemberId,'Mem',10) WHERE Id =''
	END
GO
DROP TRIGGER Trig_NextMemberId

-- Tạo bảng UserLibrary
CREATE TABLE UserLibrary
(
	PersonId VARCHAR(15) PRIMARY KEY
)


CREATE TRIGGER Trig_AddLibrarian ON dbo.Librarian
FOR INSERT
AS 
	BEGIN
	    DECLARE @LibrarianId VARCHAR(15)
		SET @LibrarianId = ( SELECT TOP 1 Id FROM dbo.Librarian 
												ORDER BY Id DESC)
		INSERT INTO dbo.UserLibrary
		(
		    PersonId
		)
		VALUES
		(@LibrarianId-- PersonId - varchar(15)
		)
	END
GO

CREATE TRIGGER Trig_AddMember ON dbo.Member
FOR INSERT
AS 
	BEGIN
	    DECLARE @MemberId VARCHAR(15)
		SET @MemberId = ( SELECT TOP 1 Id FROM dbo.Member 
												ORDER BY Id DESC)
		INSERT INTO dbo.UserLibrary
		(
		    PersonId
		)
		VALUES
		(
			@MemberId-- PersonId - varchar(15)
		)
	END
GO


CREATE TRIGGER Trig_AddLibrarianAccount ON dbo.Librarian
FOR INSERT
AS
	BEGIN
		DECLARE @LibrarianId VARCHAR(6)
		SET @LibrarianId = ( SELECT TOP 1 Id FROM dbo.Librarian 
												ORDER BY Id DESC)
		INSERT INTO dbo.Account
		(
		    PersonId,
		    Username,
		    Password,
		    AcType
		)
		VALUES
		(   @LibrarianId, -- PersonId - varchar(15)
		    @LibrarianId, -- Username - varchar(20)
		    '000000', -- Password - varchar(32)
		    2   -- AcType - int
		    )

	END
GO

DROP TRIGGER dbo.Trig_AddLibrarianAccount

CREATE TRIGGER Trig_AddMemberAccount ON dbo.Member
FOR INSERT
AS
	BEGIN
		DECLARE @MemberId VARCHAR(10)
		SET @MemberId = ( SELECT TOP 1 Id FROM dbo.Member 
												ORDER BY Id DESC)
		INSERT INTO dbo.Account
		(
		    PersonId,
		    Username,
		    Password,
		    AcType
		)
		VALUES
		(   @MemberId, -- PersonId - varchar(15)
		    @MemberId, -- Username - varchar(20)
		    '00000000', -- Password - varchar(32)
		    3   -- AcType - int
		    )

	END
GO

DROP TRIGGER dbo.Trig_AddMemberAccount
-- Tạo bảng AccountType

CREATE TABLE AccountType
(
	ACId  int IDENTITY(1,1) PRIMARY KEY,
	Type varchar(10)

)

-- Tạo bảng Account

CREATE TABLE Account
(
	PersonId  varchar(15) PRIMARY KEY,
	Username  varchar(20) UNIQUE,
	Password   varchar(32),
	AcType int

	FOREIGN KEY(PersonId) REFERENCES dbo.UserLibrary(PersonId),
	FOREIGN KEY(AcType) REFERENCES dbo.AccountType(ACId)
)
GO 


--Tạo bảng Author

CREATE TABLE Author
(
	Id  int IDENTITY(1,1) PRIMARY KEY,
	FirstName  NVARCHAR(10),
	LastName  NVARCHAR(20),
	Birthday  DATE,
	Sex  NVARCHAR(5),
	NickName  NVARCHAR(30)
)
GO 


-- Tạo bảng Publisher

CREATE TABLE Publisher
(
	Id  VARCHAR(10) PRIMARY KEY,
	Name  NVARCHAR(100),
	PhoneNumber  VARCHAR(15),
	Address  NVARCHAR(100),
	Email NVARCHAR(30)
)
GO 

-- Tạo bảng BookCategory

CREATE TABLE BookCategory
(
	Id  VARCHAR(10) PRIMARY KEY,
	Name  NVARCHAR(50),
	LimitDays  INT,
	Status  BIT DEFAULT 1
)
GO 

-- Tạo bảng Book

CREATE TABLE Book
(
	Id  VARCHAR(10) PRIMARY KEY,
	Title  NVARCHAR(50),
	Author NVARCHAR(150),
	PublisherId  VARCHAR(10),
	YearPublisher  INT,
	BookCategoryId  VARCHAR(10),
	Price  DECIMAL(19, 4),
	Status BIT DEFAULT 1

	FOREIGN KEY(PublisherId) REFERENCES dbo.Publisher(Id),
	FOREIGN KEY(BookCategoryId) REFERENCES dbo.BookCategory(Id)

)
GO 
-- Tạo bảng BookItem


CREATE TABLE BookItem
(
	BookId  VARCHAR(10) PRIMARY KEY,
	NumberCount INT

	FOREIGN KEY(BookId) REFERENCES dbo.Book(Id)
)
GO 
DROP TABLE dbo.BookItem

-- Tạo bảng BookAuthor

CREATE TABLE BookAuthor
(
	BookId  INT,
	AuthorId  INT

	PRIMARY KEY(BookId,AuthorId),
	FOREIGN KEY(BookId) REFERENCES dbo.Book(Id),
	FOREIGN KEY(AuthorId) REFERENCES dbo.Author(Id)
)
GO 


-- Tạo bảng Borrow

CREATE TABLE Borrow
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId  VARCHAR(10),
	MemberId  VARCHAR(15),
	BorrowDate  DATE,
	Status  BIT DEFAULT 1


	FOREIGN KEY(BookId) REFERENCES dbo.Book(Id),
	FOREIGN KEY(MemberId) REFERENCES dbo.Member(Id)
)
GO 

DROP TABLE dbo.Borrow
-- Tạo bảng Return
CREATE TABLE ReturnBook
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	BorrowId  INT,
	ReturnDate DATE

	FOREIGN KEY(BorrowId) REFERENCES dbo.Borrow(Id)
)
GO 

-- Tạo bảng PayFineInfo

CREATE TABLE PayFineInfo
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	BorrowId  INT,
	Cash DECIMAL(19, 4)

	FOREIGN KEY(BorrowId) REFERENCES dbo.Borrow(Id)
)
GO 



-- Tạo hàm tìm tên gần đúng
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput 
IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý 
ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy 
AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int 
DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = 
UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + 
SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +
SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET 
@COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END




