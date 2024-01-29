create database BankDataBase

use BankDataBase;

--User Data Table for Login and Sign up
create table UserData(UserID INT IDENTITY(1,1) PRIMARY KEY ,Fname varchar(20),Lname varchar(20),Username varchar(20), E_mail varchar(100), Password varchar(64));
select * from UserData

UPDATE UserData SET LogDate ='2022-12-01' WHERE UserID = 1;

-- Account Data Table
-- ADD ACCOUNTS
create table AccountData(UserId int REFERENCES UserData(UserID), Cus_Name varchar(50), Acc_Num varchar(16) PRIMARY KEY, Acc_Title varchar(25),Acc_Typ varchar(25), TP varchar(12), Email varchar(100))
select * from AccountData

select Cus_Name from AccountData where Acc_Num = 9999999999999999

select Acc_Num from AccountData where UserId = 1

insert into AccountData values (1, 'maleesha', '')

--ACCOUNT Balance
create table MyAccounts(AccNum varchar(16) REFERENCES AccountData(Acc_Num) primary key, AccType varchar(25), Balance DECIMAL(10, 2), CustomerID int REFERENCES UserData(UserID))
select * from MyAccounts

select AccNum,AccType from MyAccounts where CustomerID = '1'
select top 1 AccNum, Balance from MyAccounts where AccType = 'Checking Account' AND CustomerID = '1'
select * from MyAccounts where CustomerID = '1'
select AccNum, Balance from MyAccounts where AccType = '' AND CustomerID = ''
select Balance from MyAccounts where AccNum = '1234512341231234' and CustomerID = 3

select top 1 AccNum, Balance from MyAccounts where CustomerID = 1




--Payment History
create table PaymentHistory(PayID int identity(1,1) primary key, CustomerID int REFERENCES UserData(UserID), AccNum varchar(16) references MyAccounts(AccNum),  PayAmount DECIMAL(10, 2), PayTo varchar(25), PayDate DATETIME)
select * from PaymentHistory where CustomerID = '1'

insert into PaymentHistory values('1', '8585858585858585', 50.00, 'Dialog', '2023-02-28')


SELECT AccNum, SUM(PayAmount) as TotalAmount FROM PaymentHistory where CustomerID = 1 GROUP BY AccNum

select PayTo, SUM(PayAmount) as TotalAmount from PaymentHistory where CustomerID = '1' group by PayTo





SELECT AccNum, SUM(PayAmount) as TotalAmount FROM PaymentHistory WHERE CustomerID = '1' GROUP BY AccNum
SELECT PayTo, SUM(PayAmount) as TotalAmount FROM PaymentHistory WHERE CustomerID = '1' GROUP BY PayTo

SELECT AccNum, SUM(Balance) AS TotalBalance FROM MyAccounts WHERE CustomerID = '1' GROUP BY AccNum





drop table PaymentHistory

update MyAccounts set Balance = 1000 where AccNum = '7894561234567896'

select AccNum, AccType, Balance from MyAccounts where AccNum = '0'

select  AccNum, Balance from MyAccounts where AccType = 'Checking Account' AND CustomerID = '1'


--create table Cards(Card_No varchar(16) primary key, Holder_Name varchar(50), expired_date date, cvv int, nick_name varchar(50), Customer_ID int References Customer(Customer_ID), balance int);
select * from Cards
drop table Cards

select * from PaymentHistory where CustomerID = 4

select Balance from MyAccounts where AccNum = '8585858585858585' AND CustomerID = 1

select Balance from MyAccounts where AccNum = '' AND CustomerID = 1


SELECT AccNum, SUM(PayAmount) as TotalAmount FROM PaymentHistory WHERE CustomerID = 1 GROUP BY AccNum

select * from PaymentHistory where CustomerID = 1

select Count(PayID) as No from PaymentHistory where CustomerID = 1