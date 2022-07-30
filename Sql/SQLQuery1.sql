CREATE DATABASE library

create table NewBook
(
bid int NOT NULL IDENTITY(1,1) primary key,
bname varchar(250) NOT NULL,
bauthor varchar(250) NOT NULL,
bpubl varchar(250) NOT NULL,
bpdate varchar(250) NOT NULL,
bprice bigint NOT NULL,
bquan bigint NOT NULL
)


select * from NewBook


create table NewStudent(
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null
)
ALTER TABLE NewStudent ADD stuid int IDENTITY(1,1) NOT NULL;

sname,enroll,dep,sem,contact,email
ALTER TABLE NewStudent DROP COLUMN stuid;

insert into NewStudent(sname,enroll,dep,sem,contact,email)
values('asdsa','asdasd','asdsad','asdd','445326314','ghfdegdfg');
select * from NewStudent


create table IRBook(
id int NOT NULL IDENTITY(1,1) primary key,
std_enroll varchar(250) not null,
std_name varchar(250) not null,
std_dep varchar(250) not null,
std_sem varchar(250) not null,
std_contact varchar(250) not null,
std_email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar(250),
);

select * from IRBook
 
 std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_datebook_return_date