CREATE DATABASE Hostel_Management_System
use [HOSTEL]



CREATE TABLE Hostel2(
  Hostel_id int NOT NULL  ,
  Hostel_name varchar(255) NOT NULL,
  current_no_of_rooms varchar(255) DEFAULT NULL,
  No_of_rooms varchar(255) DEFAULT NULL,
  No_of_students varchar(255) DEFAULT NULL,
  PRIMARY KEY (Hostel_id)
)

select * from Hostel2



CREATE TABLE Room1 (
  Room_id int NOT NULL,
  Hostel_id int NOT NULL,
  Room_No int NOT NULL,
  Allocated tinyint DEFAULT '0',
  PRIMARY KEY (Room_id),
  FOREIGN KEY (Hostel_id) REFERENCES Hostel2 (Hostel_id)
) 
select * from Room1;



CREATE TABLE Student2(
  Student_id varchar(255) NOT NULL,
  Fname varchar(255) NOT NULL,
  Lname varchar(255) NOT NULL,
  Mob_no varchar(255) NOT NULL,
  Dept varchar(255) NOT NULL,
  Year_of_study varchar(255) NOT NULL,
  Hostel_id int DEFAULT NULL,
  Room_id int DEFAULT NULL,
   Pwd varchar(255) NOT NULL,
  PRIMARY KEY (Student_id),
 FOREIGN KEY (Hostel_id) REFERENCES Hostel2(Hostel_id),
 FOREIGN KEY (Room_id) REFERENCES Room1 (Room_id)
)

use [HOSTEL]
select * from Student2;

CREATE TABLE Application2(
  Application_id int identity(1,1) ,
  Student_id varchar(255) NOT NULL,
  Hostel_id int NOT NULL,
  Application_status tinyint DEFAULT NULL,
  Room_No int DEFAULT NULL,
  Message1 varchar(255) DEFAULT NULL,
  PRIMARY KEY (Application_id),
  FOREIGN KEY (Student_id) REFERENCES Student2(Student_id),
  FOREIGN KEY (Hostel_id) REFERENCES Hostel2(Hostel_id)
) 

use [HOSTEL]
select * from Application2;

delete from Application2 where Application_id=2;


CREATE TABLE Message2 (
  msg_id int NOT NULL ,
  sender_id varchar(255) DEFAULT NULL,
  receiver_id varchar(255) DEFAULT NULL,
  hostel_id int DEFAULT NULL,
  subject_h varchar(255) DEFAULT NULL,
  message1 varchar(255) DEFAULT NULL,
  msg_date varchar(255) DEFAULT NULL,
  PRIMARY KEY (msg_id),
  FOREIGN KEY (hostel_id) REFERENCES Hostel2(Hostel_id)
) 


CREATE TABLE Hostel_Manager2 (
  Hostel_man_id int  IDENTITY(1,1)  ,
  Username varchar(255) NOT NULL,
  Fname varchar(255) NOT NULL,
  Lname varchar(255) NOT NULL,
  Mob_no varchar(255) NOT NULL,
  Hostel_id  int NOT NULL,
  Pwd varchar(255) NOT NULL,
  Isadmin tinyint  DEFAULT '0',
  PRIMARY KEY (Hostel_man_id),
  UNIQUE (Username),
  FOREIGN KEY (Hostel_id) REFERENCES Hostel2 (Hostel_id)
)
use[HOSTEL]
select * from Hostel_Manager2

CREATE TABLE ADMIN(
username varchar(40),
pass varchar(40)
)

insert into ADMIN
values('muhammadali',123)
insert into ADMIN
values('muhammadakram',456)
select * from ADMIN;

use[HOSTEL]
SET IDENTITY_INSERT Hostel ON;

insert into Hostel2 VALUES (1,'A',20,30,100);
insert into Hostel2 VALUES (2,'B',10,15,60);
insert into Hostel VALUES (2,'B',10,15,60);

drop table Hostel


SET IDENTITY_INSERT Application2 ON;




insert into Application2(Application_id,Student_id,Hostel_id, Application_status, Room_No, Message1)  VAlUES(1,'3123458906',1,1,NULL,'I am handicaped,so I prefer room in ground floor');
select * from Application2;

SET IDENTITY_INSERT Application2 OFF;

insert into Student2 VALUES ('3123458906','sidra','khan','03004198867','CS',1,1,1,'abc');
select * from Student2;


insert into Student1 VALUES ('3123458906','sidra','khan','03004198867','CS',1,1,1,'abc');
select * from Student1;
delete Student1

SET IDENTITY_INSERT Room1 ON;


insert into Room1(Room_id,Hostel_id,Room_No,Allocated) VALUES(1,1,1,0);
select * from Room1;
SET IDENTITY_INSERT Room1 OFF;

Delete from Application1 where Application_id in (2,3,4,5,6,7);
DELETE t1,t2  FROM Student2 as t1
JOIN Application2 as t2 ON t1.student_id = t1.student.id

drop table Student1

drop database Hostel_Management_System
 drop table Hostel
