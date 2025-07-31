create database Grifindo_Toy;
use Grifindo_Toy;

create table Login (
username varchar(255) primary key,
password varchar(50));

insert into Login values('Admin1','admin1'),
('Admin2','admin2');

create table Employees (
    emp_id int primary key,
    emp_name varchar(50),
    address varchar(255),
	dob date,
	gender varchar(50),
	tp int,
    monthly_salary int,
    overtime_rate_hourly int,
    allowances int
);

create table Settings (
    setting_id int primary key,
	salary_month varchar(20),
    salary_cycle_days int,
    salary_cycle_begin_date date,
    salary_cycle_end_date date,
    annual_leave_days int
);

CREATE TABLE Salary_Details (
    salary_id int primary key,
    emp_id int,
    date_range_start date,
    date_range_end date,
    total_absent_days int,
    total_overtime_hours int,
	no_pay int,
    base_pay int,
    gross_pay int,
    FOREIGN KEY (emp_id) REFERENCES Employees(emp_id)
);

select* from Salary_Details;



