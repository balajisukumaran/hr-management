use [16MayCHN];
<------------------------------------------------------------------------------------->
<----balaji.CivilStatus_HR_Batch4------->
create table balaji.CivilStatus_HR_Batch4
(
StatusId int identity(20000,1) not null primary key,
StatusDescription varchar(50)
);

drop table balaji.CivilStatus_HR_Batch4
<--Insert->

create procedure balaji.SP_INSERT_CivilStatus_HR_Batch4
@aStatusDescription varchar(30)
as
insert into balaji.CivilStatus_HR_Batch4(StatusDescription) values (@aStatusDescription)
return 0

exec balaji.SP_INSERT_CivilStatus_HR_Batch4 'Married'
exec balaji.SP_INSERT_CivilStatus_HR_Batch4 'Single'

select * from balaji.CivilStatus_HR_Batch4;
<-----Get Next Id------>

create procedure balaji.SP_NEXTID_CivilStatus_HR_Batch4
@aNextStatusId int output
as
begin 
select @aNextStatusId= IDENT_CURRENT('balaji.CivilStatus_HR_Batch4') + IDENT_INCR('balaji.CivilStatus_HR_Batch4');
end

declare @a int 
exec balaji.SP_NEXTID_CivilStatus_HR_Batch4 @a out



<--Select all->
create procedure balaji.SP_SELECTALL_CivilStatus_HR_Batch4
AS
select * from balaji.CivilStatus_HR_Batch4
return 0

exec balaji.SP_SELECTALL_CivilStatus_HR_Batch4

<---Update->

create procedure balaji.SP_UPDATE_CivilStatus_HR_Batch4
@aStatusId int,
@aStatusDescription varchar(50)
as
update balaji.CivilStatus_HR_Batch4 set StatusDescription=@aStatusDescription where StatusId= @aStatusId;

select * from balaji.CivilStatus_HR_Batch4;

exec balaji.SP_UPDATE_CivilStatus_HR_Batch4 20000,'Married'


<--Delete-->
create procedure balaji.SP_DELETE_CivilStatus_HR_Batch4
@aStatusId int
as
delete from balaji.CivilStatus_HR_Batch4 where StatusId=@aStatusId;

select * from balaji.CivilStatus_HR_Batch4

exec balaji.SP_DELETE_CivilStatus_HR_Batch4 20000


<---Search By Id-->

create procedure balaji.SP_SEARCHBY_CivilStatus_HR_Batch4
@aStatusId int
as
select * from balaji.CivilStatus_HR_Batch4 where StatusId=@aStatusId;

select * from balaji.CivilStatus_HR_Batch4

exec balaji.SP_SEARCHBY_CivilStatus_HR_Batch4 20002

<--------------------------------------------------------------------------------------->

<------------------------------------------------------------------------------------------->

<----balaji.Level_HR_Batch4------->

create table balaji.Level_HR_Batch4
(LevelId int identity(30000,1) not null primary key,
LevelDescription varchar(30)
);

select * from balaji.Level_HR_Batch4;
<----INSERT------>

create procedure balaji.SP_INSERT_Level_HR_Batch4
@aLevelDescription varchar(30)
as
insert into balaji.Level_HR_Batch4(LevelDescription)
values(@aLevelDescription)
return 0;


exec balaji.SP_INSERT_Level_HR_Batch4 'Beginner'
exec balaji.SP_INSERT_Level_HR_Batch4 'Intermediate'
exec balaji.SP_INSERT_Level_HR_Batch4 'Advanced'

select * from balaji.Level_HR_Batch4
<--------Next ID----------->
create procedure balaji.SP_NEXTID_Level_HR_Batch4
@aNextLevelId int output
as 
begin
select @aNextLevelId=IDENT_CURRENT('balaji.Level_HR_Batch4') + IDENT_INCR('balaji.Level_HR_Batch4') ;
   end



   declare @a int
   exec balaji.SP_Next_MedId @a out



<----select all----->
create procedure balaji.SP_SELECTALL_Level_HR_Batch4
AS
select * from balaji.Level_HR_Batch4
return 0

exec balaji.SP_SELECTALL_Level_HR_Batch4


<---Search By---------->

create Procedure balaji.SP_SEARCHBY_Level_HR_Batch4
@aLevelId int
as 
select * from balaji.Level_HR_Batch4 where LevelId=@aLevelId
return 0

exec balaji.SP_SEARCHBY_Level_HR_Batch4 30000

<--Update---->

create procedure balaji.SP_UPDATE_Level_HR_Batch4
@aLevelId int,
@aLevelDescription varchar(30)
as
update balaji.Level_HR_Batch4 set LevelDescription=@aLevelDescription where LevelId=@aLevelId;

exec balaji.SP_UPDATE_Level_HR_Batch4 30000, 'Beginner'

<---Delete-->
create procedure balaji.SP_DELETE_Level_HR_Batch4
@aLevelId int
as
delete from balaji.Level_HR_Batch4 where LevelId=@aLevelId

select * from balaji.Level_HR_Batch4

exec balaji.SP_DELETE_Level_HR_Batch4 30000
<------------------------------------------------------------------------------------------->

<--------------------------------------------------------------------------------------------->
<-----------Speciality_HR_Batch4---------------->



create table balaji.Speciality_HR_Batch4
(SpecialityID int identity(40000,1) not null primary key, 
SpecialityName varchar(30)
);

drop table balaji.Speciality_HR_Batch4

select * from balaji.Speciality_HR_Batch4
<--------Next ID----------------------->
create procedure balaji.SP_NEXTID_Speciality_HR_Batch4
@aNextSpecialityID int output
as 
begin
select @aNextSpecialityID=IDENT_CURRENT('balaji.Speciality_HR_Batch4') + IDENT_INCR('balaji.Speciality_HR_Batch4') ;
   end



<----Insert------->

create procedure balaji.SP_INSERT_Speciality_HR_Batch4 
@aSpecialityName varchar(30)
as
Insert into balaji.Speciality_HR_Batch4
(SpecialityName)
values (@aSpecialityName)
return 0

exec balaji.SP_INSERT_Speciality_HR_Batch4 'DOT Net'
exec balaji.SP_INSERT_Speciality_HR_Batch4 'Java'


<----Select all----->
create procedure balaji.SP_SELECTALL_Speciality_HR_Batch4 
as
select * from balaji.Speciality_HR_Batch4
return 0


exec balaji.SP_SELECTALL_Speciality_HR_Batch4
<-----SELECTBY---------->
create procedure balaji.SP_SELECTBY_Speciality_HR_Batch4
@aSpecialityID int
as
select * from balaji.Speciality_HR_Batch4 where SpecialityID=@aSpecialityID
return 0

exec balaji.SP_SELECTBY_Speciality_HR_Batch4 40000

<--UPDATE--------->

create procedure balaji.SP_UPDATE_Speciality_HR_Batch4
@aSpecialityID int , 
@aSpecialityName varchar(30)
as
update balaji.Speciality_HR_Batch4 set SpecialityName=@aSpecialityName where SpecialityID=@aSpecialityID

exec balaji.SP_UPDATE_Speciality_HR_Batch4 40000, 'Dot Net'


<-----DELETE---------->


Create procedure balaji.SP_DELETE_Speciality_HR_Batch4
@aSpecialityID int 
as
delete from balaji.Speciality_HR_Batch4 where SpecialityID=@aSpecialityID

exec balaji.SP_DELETE_Speciality_HR_Batch4 40001

select * from balaji.Speciality_HR_Batch4


<----------------------------------------------------------------------->
<--Category_HR_Batch4----->


create table balaji.Category_HR_Batch4
(
CategoryID int identity(70000,1) not null primary key,
CategoryName varchar(20),
CategoryDescription varchar(30)
);

select * from balaji.Category_HR_Batch4
<--------Next ID----------------------->
create procedure balaji.SP_NEXTID_Category_HR_Batch4
@aNextCategoryID int output
as 
begin
select @aNextCategoryID=IDENT_CURRENT('balaji.Category_HR_Batch4') + IDENT_INCR('balaji.Category_HR_Batch4') ;
   end

<-----------INSERT------------------------>

create procedure balaji.SP_INSERT_Category_HR_Batch4
@aCategoryName varchar(20),
@aCategoryDescription varchar(30)
as
insert into balaji.Category_HR_Batch4 (CategoryName,CategoryDescription) values
(@aCategoryName,@aCategoryDescription)
return 0


exec balaji.SP_INSERT_Category_HR_Batch4 'category1','catdesc1'

exec balaji.SP_INSERT_Category_HR_Batch4 'category2','catdesc2'
select * from balaji.Category_HR_Batch4
<---------------SELECT ALL------------------------------>
create procedure  balaji.SP_SELECTALL_Category_HR_Batch4
as
select * from balaji.Category_HR_Batch4
return 0

exec balaji.SP_SELECTALL_Category_HR_Batch4

<------------SELECT BY-------------------------->
create procedure balaji.SP_SELECTBY_Category_HR_Batch4
@aCategoryID int
as
select * from Category_HR_Batch4 where CategoryID=@aCategoryID
return 0

exec balaji.SP_SELECTBY_Category_HR_Batch4 70000

<-----------------UPDATE------------------------------->

create procedure balaji.SP_UPDATE_Category_HR_Batch4
@aCategoryID int,
@aCategoryName varchar(20),
@aCategoryDescription varchar(30)
as
update balaji.Category_HR_Batch4 set CategoryName=@aCategoryName, CategoryDescription=@aCategoryDescription
where CategoryID=@aCategoryID
return 0

exec balaji.SP_UPDATE_Category_HR_Batch4 70000,'category1','catdesc1'

<----DELETE------>

create procedure balaji.SP_DELETE_Category_HR_Batch4
@aCategoryID int
as
delete from  balaji.Category_HR_Batch4 where CategoryID= @aCategoryID

exec balaji.SP_DELETE_Category_HR_Batch4 70000

<---------------------------------------------------------------------------->

<-- balaji.Skill_HR_Batch4--->

create table balaji.Skill_HR_Batch4 
(SkillID int identity(80000,1)not null primary key,
SkillName varchar(30),
SkillDescription varchar(30),
CategoryId int,
foreign key(CategoryId) references balaji.Category_HR_Batch4(CategoryID)
);
<--------Next ID----------------------->
create procedure balaji.SP_NEXTID_Skill_HR_Batch4 
@aNextSkillID int output
as 
begin
select @aNextSkillID=IDENT_CURRENT('balaji.Skill_HR_Batch4 ') + IDENT_INCR('balaji.Skill_HR_Batch4 ') ;
   end


<-------INSERT------->

create procedure balaji.SP_INSERT_Skill_HR_Batch4
@aSkillName varchar(30),
@aSkillDescription varchar(30),
@aCategoryId int
as
insert into balaji.Skill_HR_Batch4 (SkillName,SkillDescription,CategoryId) values(@aSkillName,@aSkillDescription,@aCategoryId)
return 0

exec balaji.SP_INSERT_Skill_HR_Batch4 'Skill1','SkillDesc','70000'

exec balaji.SP_INSERT_Skill_HR_Batch4 'Skill1','SkillDesc','70001'

select * from balaji.Skill_HR_Batch4
<----SELECT ALL-------->

create procedure balaji.SP_SELECTALL_Skill_HR_Batch4
as
select * from balaji.Skill_HR_Batch4
return 0

exec balaji.SP_SELECTALL_Skill_HR_Batch4
<-----SELECT BY---------->

create procedure balaji.SP_SELECTBY_Skill_HR_Batch4
@aSkillID int
as
select * from balaji.Skill_HR_Batch4 where SkillID=@aSkillID
return 0

exec balaji.SP_SELECTBY_Skill_HR_Batch4 80000
<-------UPDATE------------>

create procedure balaji.SP_UPDATE_Skill_HR_Batch4
@aSkillID int,
@aSkillName varchar(30),
@aSkillDescription varchar(30),
@aCategoryId int 
as
update balaji.Skill_HR_Batch4 set SkillName=@aSkillName,SkillDescription=@aSkillDescription,
CategoryId=@aCategoryId where SkillID=@aSkillID

return 0

exec balaji.SP_UPDATE_Skill_HR_Batch4 80001, 'Skill2','Skilldesc','70000' 

<--DELETE--->
create procedure balaji.SP_DELETE_Skill_HR_Batch4
@aSkillID int
as
delete from balaji.Skill_HR_Batch4 where SkillID=@aSkillID
return 0

exec balaji.SP_DELETE_Skill_HR_Batch4 80000

<--------------------------------------------->
<---balaji.Project_HR_Batch4----->

create table balaji.Project_HR_Batch4 
(ProjectID int identity(60000,1) not null primary key,
ProjectName varchar(20),
Description varchar(30),
Client varchar(20),
StartDate date,
EndDate date
);

<--------Next ID----------------------->
create procedure balaji.SP_NEXTID_Project_HR_Batch4 
@aNextProjectID int output
as 
begin
select @aNextProjectID=IDENT_CURRENT('balaji.Project_HR_Batch4 ') + IDENT_INCR('balaji.Project_HR_Batch4 ') ;
   end
   drop procedure  balaji.SP_NEXTID_Project_HR_Batch4

<-----INSERT------>
create procedure balaji.SP_INSERT_Project_HR_Batch4
@aProjectName varchar(20),
@aDescription varchar(30),
@aClient varchar(20),
@aStartDate date,
@aEndDate date
as
insert into balaji.Project_HR_Batch4(ProjectName,
Description,
Client,
StartDate,
EndDate)
 values(@aProjectName,
@aDescription,
@aClient,
@aStartDate,
@aEndDate)
return 0


exec balaji.SP_INSERT_Project_HR_Batch4 'project1','Desc','client1','12/12/2018','12/12/2017'

exec balaji.SP_INSERT_Project_HR_Batch4 'project2','Desc','client1','12/12/2018','12/12/2017'

select * from balaji.Project_HR_Batch4

<--SELECT ALL-------->

create procedure balaji.SP_SELECTALL_Project_HR_Batch4
as
select * from balaji.Project_HR_Batch4
return 0


exec balaji.SP_SELECTALL_Project_HR_Batch4
<---SELECT BY---------->
create procedure balaji.SP_SELECTBY_Project_HR_Batch4
@aProjectID int
as
select * from balaji.Project_HR_Batch4 where ProjectID=@aProjectID;

exec balaji.SP_SELECTBY_Project_HR_Batch4 60000
<-------UPDATE------------->

create procedure balaji.SP_UPDATE_Project_HR_Batch4
@aProjectID int ,
@aProjectName varchar(20),
@aDescription varchar(30),
@aClient varchar(20),
@aStartDate date,
@aEndDate date
as
update balaji.Project_HR_Batch4 set ProjectName=@aProjectName,
Description=@aDescription, Client=@aClient,
StartDate=@aStartDate,EndDate=@aEndDate
where 
ProjectID=@aProjectID
return 0

select * from balaji.Project_HR_Batch4
exec balaji.SP_UPDATE_Project_HR_Batch4 60001,'Project2 ','Desc','client1','2018-12-12','2017-12-12'


<---------DELETE---->
create procedure balaji.SP_DELETE_Project_HR_Batch4
@aProjectID int
as
delete from balaji.Project_HR_Batch4 where ProjectID=@aProjectID
return 0

exec balaji.SP_DELETE_Project_HR_Batch4 60000
<------------------------------------------------------------------------>

<----------Employee_HR_Batch4--------------------------->


 
create table balaji.Employee_HR_Batch4 
(
EmployeeID integer identity(90000,1) not null primary key,
FirstName varchar(50),
MiddleName varchar(50),
LastName varchar(50),
BirthDate Date,
Age integer,
Gender varchar(1),
CivilStatusId integer,
Religion varchar(50),
Citizenship varchar(50),
MobileNo varchar(15),
HomePhoneNo varchar(15),
Street1 varchar(25),
Street2 varchar(25),
City varchar(15),
UserState varchar(15),
Zip integer,
Country varchar(25),
ProjectId integer,
SkillId integer,
EducationalBackground varchar(30),
foreign key(CivilStatusId) references balaji.CivilStatus_HR_Batch4(StatusId),
foreign key(ProjectId) references balaji.Project_HR_Batch4(ProjectID),
foreign key(SkillId) references balaji.Skill_HR_Batch4(SkillID)
);
<-------Next ID--------------->
create procedure balaji.SP_NEXTID_Employee_HR_Batch4 
@aEmployeeID int output
as 
begin
select @aEmployeeID=IDENT_CURRENT('balaji.Employee_HR_Batch4') + IDENT_INCR('balaji.Employee_HR_Batch4') ;
   end

   drop procedure balaji.SP_NEXTID_Employee_HR_Batch4


drop table balaji.Employee_HR_Batch4 
select * from balaji.Employee_HR_Batch4 
<----Insert--------->
create procedure balaji.SP_INSERT_Employee_HR_Batch4
@aFirstName varchar(50),
@aMiddleName varchar(50),
@aLastName varchar(50),
@aBirthDate Date,
@aAge integer,
@aGender varchar(1),
@aCivilStatusId integer,
@aReligion varchar(50),
@aCitizenship varchar(50),
@aMobileNo varchar(15),
@aHomePhoneNo varchar(15),
@aStreet1 varchar(25),
@aStreet2 varchar(25),
@aCity varchar(15),
@aUserState varchar(15),
@aZip integer,
@aCountry varchar(25),
@aProjectId integer,
@aSkillId integer,
@aEducationalBackground varchar(30)
as
insert into balaji.Employee_HR_Batch4(FirstName,
MiddleName,
LastName,
BirthDate,
Age,
Gender,
CivilStatusId,
Religion,
Citizenship,
MobileNo,
HomePhoneNo,
Street1,
Street2,
City,
UserState,
Zip,
Country,
ProjectId,
SkillId,
EducationalBackground) values(@aFirstName,
@aMiddleName,
@aLastName,
@aBirthDate,
@aAge,
@aGender,
@aCivilStatusId,
@aReligion,
@aCitizenship,
@aMobileNo,
@aHomePhoneNo,
@aStreet1,
@aStreet2,
@aCity,
@aUserState,
@aZip,
@aCountry,
@aProjectId,
@aSkillId,
@aEducationalBackground)
return 0

exec balaji.SP_INSERT_Employee_HR_Batch4 'Balaji','.','Sukumaran','11/11/1996',23,'m',20001,'Hindu','Indian','9790543173','9790543173','st1','st2','Chennai','TamilNadu',600050,'Indian',60000,80000,'BE'

select * from balaji.Employee_HR_Batch4 

<----SELECT ALL------>

create procedure balaji.SP_SELECTALL_Employee_HR_Batch4
as
select * from balaji.Employee_HR_Batch4
return 0

exec  balaji.SP_SELECTALL_Employee_HR_Batch4

<--select by----->
create procedure balaji.SP_SELECTBY_Employee_HR_Batch4
@aEmployeeID integer
as
select * from balaji.Employee_HR_Batch4 where EmployeeID=@aEmployeeID
return 0

exec balaji.SP_SELECTBY_Employee_HR_Batch4 90000

<----Update----->

create procedure balaji.SP_UPDATE_Employee_HR_Batch4
@aEmployeeID integer,
@aFirstName varchar(50),
@aMiddleName varchar(50),
@aLastName varchar(50),
@aBirthDate Date,
@aAge integer,
@aGender varchar(1),
@aCivilStatusId integer,
@aReligion varchar(50),
@aCitizenship varchar(50),
@aMobileNo varchar(15),
@aHomePhoneNo varchar(15),
@aStreet1 varchar(25),
@aStreet2 varchar(25),
@aCity varchar(15),
@aUserState varchar(15),
@aZip integer,
@aCountry varchar(25),
@aProjectId integer,
@aSkillId integer,
@aEducationalBackground varchar(30)
as
update balaji.Employee_HR_Batch4 set 
FirstName=@aFirstName,
MiddleName=@aMiddleName,
LastName=@aLastName,
BirthDate=@aBirthDate,
Age=@aAge,
Gender=@aGender,
CivilStatusId=@aCivilStatusId,
Religion=@aReligion,
Citizenship=@aCitizenship,
MobileNo=@aMobileNo,
HomePhoneNo=@aHomePhoneNo,
Street1=@aStreet1,
Street2=@aStreet2,
City=@aCity,
UserState=@aUserState,
Zip=@aZip,
Country=@aCountry,
ProjectId=@aProjectId,
SkillId=@aSkillId,
EducationalBackground=@aEducationalBackground
where  EmployeeID =@aEmployeeID
return 0

exec balaji.SP_UPDATE_Employee_HR_Batch4 90000,'Balaji','.','Sukumaran','11/11/1996',23,'m',20001,'Hindu','Indian','9790543173','9790543173','st1','st2','Chennai','TamilNadu',600050,'Indian',60000,80000,'BE'



select * from balaji.Employee_HR_Batch4

<----Delete-------->
create procedure balaji.SP_DELETE_Employee_HR_Batch4
@aEmployeeID integer
as
delete from balaji.Employee_HR_Batch4 where EmployeeID=@aEmployeeID

exec balaji.SP_DELETE_Employee_HR_Batch4 90000

select * from balaji.Employee_HR_Batch4

<----------------------------------------------------------------------------------------------->

<---balaji.CapgeminiDetails_HR_Batch4----->

create table balaji.CapgeminiDetails_HR_Batch4
(EmployeeID int,
Email varchar(30),
LevelId int,
DateHired date,
SpecialityId int,
StatusId int,
foreign key(EmployeeID) references balaji.Employee_HR_Batch4(EmployeeID),
foreign key(LevelId) references balaji.Level_HR_Batch4(LevelId),
foreign key(SpecialityId) references balaji.Speciality_HR_Batch4(SpecialityID),
foreign key(StatusId) references balaji.CivilStatus_HR_Batch4(StatusId),
);
drop table balaji.CapgeminiDetails_HR_Batch4

<---INSERT---->
create procedure balaji.SP_INSERT_CapgeminiDetails_HR_Batch4
@aEmployeeID int,
@aEmail varchar(30),
@aLevelId int,
@aDateHired date,
@aSpecialityId int,
@aStatusId int
as
insert into balaji.CapgeminiDetails_HR_Batch4 (EmployeeID,
Email,
LevelId,
DateHired,
SpecialityId,
StatusId) values (@aEmployeeID,
@aEmail,
@aLevelId,
@aDateHired,
@aSpecialityId,
@aStatusId)
return 0

exec balaji.SP_INSERT_CapgeminiDetails_HR_Batch4 90000,'balaji@gmail.com',30000,'10/11/1996',40000,20001

<--Select All------->
create procedure balaji.SP_SELECTALL_CapgeminiDetails_HR_Batch4
as
select * from balaji.CapgeminiDetails_HR_Batch4
return 0

exec balaji.SP_SELECTALL_CapgeminiDetails_HR_Batch4


<----Select by------>
create procedure balaji.SP_SELECTBY_CapgeminiDetails_HR_Batch4
@aEmployeeID integer
as
select * from balaji.CapgeminiDetails_HR_Batch4 where EmployeeID=@aEmployeeID
return 0

exec balaji.SP_SELECTBY_CapgeminiDetails_HR_Batch4 90000

<-----UPDATE------>
create procedure balaji.SP_UPDATE_CapgeminiDetails_HR_Batch4
@aEmployeeID int,
@aEmail varchar(30),
@aLevelId int,
@aDateHired date,
@aSpecialityId int,
@aStatusId int
as
update balaji.CapgeminiDetails_HR_Batch4 set Email=@aEmail,LevelId=@aLevelId,DateHired=@aDateHired,
SpecialityId=@aSpecialityId,StatusId=@aStatusId
where EmployeeID=@aEmployeeID

exec balaji.SP_UPDATE_CapgeminiDetails_HR_Batch4 90000,'balaji@hotmail.com',30000,'10/11/1996',40000,20001


<---Delete--->
create procedure balaji.SP_DELETE_CapgeminiDetails_HR_Batch4
@aEmployeeID int
as
delete from balaji.CapgeminiDetails_HR_Batch4 where EmployeeID=@aEmployeeID
return 0

exec balaji.SP_DELETE_CapgeminiDetails_HR_Batch4 90000







<------------------------------------>

<--------balaji.Users_HR_Batch4--------------------------->
create table balaji.Users_HR_Batch4( 
UserId integer identity(1,1) not null primary key  ,
UserName varchar(50),
UserPassword varchar(50),
FirstName varchar(50),
LastName varchar(50) 
);
<------get Id----------->
create procedure balaji.SP_NEXTID_Users_HR_Batch4
@aUserId int output
as 
begin
select @aUserId=IDENT_CURRENT('balaji.Users_HR_Batch4') + IDENT_INCR('balaji.Users_HR_Batch4') ;
   end

   drop procedure balaji.SP_NEXTID_Employee_HR_Batch4

drop table balaji.Users_HR_Batch4

<-------Insert------------------>

create procedure balaji.SP_INSERT_Users_HR_Batch4
@aUserName varchar(50),
@aUserPassword varchar(50),
@aFirstName varchar(50),
@aLastName varchar(50) 
as
insert into balaji.Users_HR_Batch4(UserName,
UserPassword,
FirstName,
LastName)
 values  (@aUserName,
@aUserPassword,
@aFirstName,
@aLastName)
return 0

exec balaji.SP_INSERT_Users_HR_Batch4 'admin','admin','balaji','sukumaran'
exec balaji.SP_INSERT_Users_HR_Batch4 'HRClerk','hrclerk','sucharita','padira'



<----SELECT ALL--------->

create procedure balaji.SP_SELECTALL_Users_HR_Batch4
as
select * from balaji.Users_HR_Batch4
return 0

exec balaji.SP_SELECTALL_Users_HR_Batch4
<-------SELECT BY-------------------->
create procedure balaji.SP_SELECTBY_Users_HR_Batch4
@aUserId integer
as
select * from balaji.Users_HR_Batch4 where UserId=@aUserId;

exec balaji.SP_SELECTBY_Users_HR_Batch4 1

<-------Update------------------------>

create procedure balaji.SP_UPDATE_Users_HR_Batch4
@aUserId integer,
@aUserName varchar(50),
@aUserPassword varchar(50),
@aFirstName varchar(50),
@aLastName varchar(50) 
as
update balaji.Users_HR_Batch4 set UserName=@aUserName,
UserPassword=@aUserPassword,
FirstName=@aFirstName,
LastName=@aLastName  where UserId=@aUserId


exec balaji.SP_UPDATE_Users_HR_Batch4 2,'hrclerk','hrclerk','sucharita','padira'
<--------DELETE--------------------->

create procedure balaji.SP_DELETE_Users_HR_Batch4
@aUserId integer
as
delete from balaji.Users_HR_Batch4 where UserId=@aUserId

exec balaji.SP_DELETE_Users_HR_Batch4 1


<-------------------Login Check------------------------------------------------------------->


create procedure balaji.SP_LoginCheck_Users_HR_Batch4
@aUsername varchar(50),
@aPassword varchar(50)
as
select * from balaji.Users_HR_Batch4 where UserName=@aUsername and UserPassword=@aPassword















<----------------------------------------------------------->
<-------balaji.Roles_HR_Batch4----------->

create table balaji.Roles_HR_Batch4
(
RoleId integer identity(100,1) not null primary key,
RoleName varchar(50)
);

<------get Id----------->
create procedure balaji.SP_NEXTID_Roles_HR_Batch4
@aRoleId int output
as 
begin
select @aRoleId=IDENT_CURRENT('balaji.Roles_HR_Batch4') + IDENT_INCR('balaji.Roles_HR_Batch4') ;
   end

<----------INSERT---------------------------->
create procedure balaji.SP_INSERT_Roles_HR_Batch4
@aRoleName varchar(50)
as
insert into balaji.Roles_HR_Batch4 (RoleName) values (@aRoleName)
return 0

exec balaji.SP_INSERT_Roles_HR_Batch4 'Admin'
exec balaji.SP_INSERT_Roles_HR_Batch4 'HRClerk'
select * from balaji.Roles_HR_Batch4

<----------Select all----------------->
create procedure balaji.SP_SELECTALL_Roles_HR_Batch4
as
select * from balaji.Roles_HR_Batch4
return 0

exec balaji.SP_SELECTALL_Roles_HR_Batch4
<-----------Select By----------------------->
create procedure balaji.SP_SELECTBY_Roles_HR_Batch4
@aRoleId integer
as
select * from balaji.Roles_HR_Batch4 where RoleId=@aRoleId
return 0

 
 exec balaji.SP_SELECTBY_Roles_HR_Batch4 100
<--------------------------------------------->
create procedure balaji.SP_UPDATE_Roles_HR_Batch4
@aRoleId integer,
@aRoleName varchar(50)
as
update balaji.Roles_HR_Batch4 set RoleName=@aRoleName
where RoleId=@aRoleId


exec balaji.SP_UPDATE_Roles_HR_Batch4 100, 'Admin'
<--------------Delete------------------------------------>
create procedure balaji.SP_DELETE_Roles_HR_Batch4
@aRoleId integer
as
delete from balaji.Roles_HR_Batch4 where RoleId= @aRoleId
return 0

exec  balaji.SP_DELETE_Roles_HR_Batch4 101

<----------------------------------------->
<-------------------------------------------------->





create table balaji.UserRoles_HR_Batch4
(
UserId integer ,
RoleId integer,
foreign key(UserId) references balaji.Users_HR_Batch4(UserId),
foreign key(RoleId) references balaji.Roles_HR_Batch4(RoleId)
);

drop table balaji.UserRoles_HR_Batch4
<----insert--------------->
create procedure balaji.SP_INSERT_UserRoles_HR_Batch4
@aUserId integer ,
@aRoleId integer
as 
insert into balaji.UserRoles_HR_Batch4(UserId,RoleId) values (@aUserId,@aRoleId)
return 0
exec balaji.SP_INSERT_UserRoles_HR_Batch4 1,100 
<----selectall------------------->
create procedure balaji.SP_SELECTALL_UserRoles_HR_Batch4
as 
select * from balaji.UserRoles_HR_Batch4
return 0

exec balaji.SP_SELECTALL_UserRoles_HR_Batch4
<--------Update------------------->
create procedure balaji.SP_UPDATE_UserRoles_HR_Batch4
@aUserId integer ,
@aRoleId integer
as
update balaji.UserRoles_HR_Batch4 set RoleId=@aRoleId where UserId=@aUserId
return 0

exec balaji.SP_UPDATE_UserRoles_HR_Batch4 1,100 

<-------------Select Role Type --------------------->
create procedure balaji.SP_UserType_Users_HR_Batch4
@aUserId integer,
@aRoleId integer
as
select * from balaji.UserRoles_HR_Batch4 where UserId=@aUserId and  RoleId=@aRoleId

exec balaji.SP_UserType_Users_HR_Batch4 2,101

<----------------------------------------------------------------------------------------------------->


<----------------------------------------------------------------------------------------------------->


--------------------------------------------------------------------------------------------------------




























----------------------------------------------------------------------------------------------------------------------------------
<----------------------------------------------------------------------------------------------------->


<-- Create table commands  ->
create table balaji.Users( 
UserId integer  ,
UserName varchar(50),
UserPassword varchar(50),
FirstName varchar(50),
LastName varchar(50) 
);




create table balaji.Roles 
(
RoleId integer,
RoleName varchar(50)
);

create table balaji.UserRoles
(
userId integer ,
RoleId integer 
);


 
create table balaji.Employee 
(
EmployeeID integer identity(90000,1) prim,
FirstName varchar(50),
MiddleName varchar(50),
LastName varchar(50),
BirthDate Date,
Age integer,
Gender varchar(1),
CivilStatus varchar(50),
Religion varchar(50),
Citizenship varchar(50),
MobileNo varchar(15),
HomePhoneNo varchar(15),
Street1 varchar(25),
Street2 varchar(25),
City varchar(15),
UserState varchar(15),
Zip integer,
Country varchar(25),
ProjectId integer,
SkillId integer,
EducationalBackground varchar(30)
);



create table balaji.CapGeminiDetails
(EmployeeID int,
Email varchar(30),
Level varchar(20),
DateHired date,
Speciality varchar(20),
Status varchar(20)
);



create table balaji.Project 
(ProjectID int,
ProjectName varchar(20),
Description varchar(30),
Client varchar(20),
StartDate date,
EndDate date
);


create table balaji.Category 
(CategoryID int,
CategoryName varchar(20),
CategoryDescription varchar(30)
);


create table balaji.Skill 
(SkillID int,
SkillName varchar(30),
SkillDescription varchar(30),
CategoryId int
);

create table balaji.CivilStatus
(StatusId int identity(20000,1) not null,
StatusDescription varchar(30)
);



create table balaji.Level
(LevelId int identity(30000,1) not null,
LevelDescription varchar(30)
);



create table balaji.Speciality
(SpecialityID int identity(40000,1) not null, 
SpecialityName varchar(30)
);





<--Primary Keys>
alter table balaji.Users 
alter column UserId integer not null;
alter table balaji.Users
ADD CONSTRAINT PK_USER 
primary key (UserId);

alter table balaji.Roles
alter column RoleId integer not null;
alter table balaji.Roles
ADD CONSTRAINT PK_ROLES
primary key (RoleId);

alter table balaji.Employee
alter column EmployeeID integer not null;
alter table balaji.Employee
add constraint PK_EMPLOYEE
primary key (EmployeeID);

alter table balaji.Project
alter column ProjectID integer not null;
alter table balaji.Project
add constraint PK_PROJECT
primary key(ProjectID);

alter table balaji.Category
alter column CategoryID integer not null;
alter table balaji.Category
add constraint PK_CATEGORY
primary key (CategoryID);

alter table balaji.Skill
alter column SkillID integer not null;
alter table balaji.Skill
add constraint PK_SKILL
primary key(SKillID);

 alter table balaji.UserRoles
 alter column RoleId integer not null;
alter table balaji.UserRoles
add constraint PK_USERROLES
primary key(RoleId);


<-- Foreign Keys ->

alter table balaji.UserRoles
add constraint FK_USERROLES
foreign key (UserId) references balaji.Users(UserId);

alter table balaji.UserRoles
add constraint FK2_USERROLES
foreign key (RoleId) references balaji.Roles(RoleId);



alter table balaji.CapGeminiDetails
add constraint FK_CAPGEMINIDETAILS
foreign key (EmployeeID) references balaji.Employee(EmployeeID);

alter table balaji.Employee
add constraint FK_EMPLOYEE
foreign key (ProjectID) references balaji.Project(ProjectID);


alter table balaji.Skill
add constraint FK_SKILL
foreign key (CategoryID) references balaji.Category(CategoryID);

alter table balaji.Employee
add constraint FK2_EMPLOYEE
foreign key (SkillId) references balaji.SKill(SkillID);