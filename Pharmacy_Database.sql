Create Database Pharmacy_Project_P;

--Drop Database Pharmacy
use Pharmacy_Project_p;

---------------------------------------------INVOIVE TABLE---------------------------------------------
Create Table Invoice_T
				(Invoice_Number Integer Not Null ,-- Identity(1000, 1),
				 Invoice_Date Date default getdate(),
				 Constraint Invoice_Number_PK Primary Key(Invoice_Number));
--Drop Table Invoice_T;
--Truncate Table Invoice_T;

Insert Into Invoice_T
Values(1,'2022-12-15');
Insert Into Invoice_T
Values(2,'2022-12-15');
Insert Into Invoice_T
Values(3,'2022-12-16');

Select * From Invoice_T;

---------------------------------------------ITEM TABLE---------------------------------------------
Create Table Item_T
				(Item_Code INTEGER Not Null,
				 Item_Name varchar(100),
				 Item_Quantity Integer, --Constraint Quantity_Check Check(Item_Quantity >= 0),
				 Item_Rack Integer,
				 Purchase_Price integer Constraint PP_Check Check(Purchase_Price > 0),
				 Sale_Price integer,
				 Expiry_Date Date,
				 Constraint  Item_Code_PK Primary Key(Item_Code),
				 Constraint SP_Check Check(Sale_Price >= Purchase_Price));

Insert Into Item_T
Values(112238, 'Tab. Panadol 500mg', 100, 2, 5, 2.75, '2025-12-31');
Insert Into Item_T
Values(112239, 'Tab. Antial 10mg', 50, 1, 15, 17, '2025-12-31');
Insert Into Item_T
Values(112240, 'Tab. Neubrol 500mg', 100, 2, 10, 12, '2025-12-31');
update Item_T
set Sale_Price = 5
where Item_Code = 112238;
Select * From Item_T;
---------------------------------------------CUSTOMER TABLE---------------------------------------------
Create Table Customer_T
				(CustomerID Integer Not Null ,--Identity(400, 1),
				 Customer_Name varchar(100) Default 'Mr. Walk In',
				 Constraint CustomerID_PK Primary Key(CustomerID));
--Truncate Table Customer_T;

Insert Into Customer_T
Values(400,'Ahmad');
Insert Into Customer_T
Values(401,'Abdur Rehman');
Insert Into Customer_T
Values(402,'Hamza');
--drop table Customer_T
Select * From Customer_T;
---------------------------------------------PHARMACIST TABLE---------------------------------------------
Create Table Pharmacist_T
					(PharmacistID Integer Not Null,
					 Pharmacist_Name varchar(50),
					 Salary integer Constraint Salary_Chk Check(Salary > 25000),
					 Constraint PharmacistID_PK Primary Key(PharmacistID));
--Drop Table Pharmacist_T;
alter table Pharmacist_T
add  age int ;
update  Pharmacist_T
set age = 22
where PharmacistID = 316
Insert Into Pharmacist_T
Values(315, 'Ali', 50000);
Insert Into  Pharmacist_T
Values(316, 'Akbar', 26000);

Select * From Pharmacist_T;
---------------------------------------------PURCHASE receipt TABLE---------------------------------------------
Create Table Purchase_Receipt_T
					(ReceiptID integer Not Null ,--Constraint ReceiptID_Chk Check(ReceiptID >= 112500),
					 Purchase_Date Date DEFAULT getdate(),
					 Constraint ReceiptID_PK Primary Key(ReceiptID));
--Drop Table Purchase_Receipt_T;


Insert Into Purchase_Receipt_T(ReceiptID,Purchase_Date)
Values(112503,'2023-4-5');
--(112500),(112501),(112502);

delete from Purchase_Receipt_T
where ReceiptID =112503;
Select * From Purchase_Receipt_T;
---------------------------------------------VENDOR TABLE---------------------------------------------
alter table Vendor_T
alter column VendorID integer Identity (3200,1);
Create Table Vendor_T
				(VendorID Integer Not Null,
				 Vendor_Name varchar(50),
				 Vendor_Contact varchar(50),
				 Constraint VendorID_PK Primary Key(VendorID));

Insert Into Vendor_T
Values(32156, 'Hussnain', '92-316-754189');
Insert Into Vendor_T
Values(32321, 'Tahir', '92-316-8956321');
Insert Into Vendor_T
Values(32189, 'Zohaib', '92-300-7894562');

Select * From Vendor_T;
---------------------------------------------PURCHASE TABLE---------------------------------------------
Create Table Purchase_T
					(ReceiptID INTEGER Not Null,
					 Item_Code INTEGER Not Null,
					 VendorID Integer,
					 Constraint Purchase_Item_CK Primary Key(ReceiptID, Item_Code),
					 Constraint ReceiptID_FK1 Foreign Key(ReceiptID) References Purchase_Receipt_T(ReceiptID) On Update Cascade On Delete Cascade,
					 Constraint Item_Code_FK1 Foreign Key(Item_Code) References Item_T(Item_Code) On Update Cascade On Delete Cascade,
					 Constraint VendorID_FK Foreign Key(VendorID) References Vendor_T(VendorID) On Update Cascade On Delete Cascade);

Insert Into Purchase_T
Values(112500, 112238, 32156);
Insert Into Purchase_T
Values(112501, 112239, 32321);
Insert Into Purchase_T
Values(112502, 112240, 32189);

Select * From Purchase_T;


---------------------------------------------ORDER TABLE---------------------------------------------
Create Table Order_T
				 (Invoice_Number Integer Not Null,
				  Item_Code INTEGER Not Null,
				  CustomerID Integer,
				  PharmacistID Integer,
				  Constraint Invoice_Item_CK Primary Key(Invoice_Number, Item_Code),
				  Constraint Invoice_Number_FK Foreign Key(Invoice_Number) References Invoice_T(Invoice_Number) On Update Cascade On Delete Cascade,
				  Constraint Item_Code_FK Foreign Key(Item_Code) References Item_T(Item_Code) On Update Cascade On Delete Cascade,
				  Constraint CustomerID_FK Foreign Key(CustomerID) References Customer_T(CustomerID) On Update Cascade On Delete Cascade,
				  Constraint PharmacistID_FK Foreign Key(PharmacistID) References Pharmacist_T(PharmacistID) On Update Cascade On Delete Cascade);

Insert Into Order_T
Values(1, 112238, 400, 315);
Insert Into Order_T
Values(2, 112238, 401, 315);
Insert Into Order_T
Values(3, 112239, 402, 316);
alter table Order_T
add Order_Quantity integer;
update Order_T
set Order_Quantity = 3
where Invoice_Number = 3
--drop table Order_T
drop table 

Select * From Order_T;
Select * From Purchase_T;
Select * From Vendor_T;
Select * From Purchase_Receipt_T;
Select * From Pharmacist_T;
Select * From Customer_T;
Select * From Item_T;
Select * From Invoice_T;

LECT Sale_Price FROM Item_T WHERE Item_Name = ;
delete from Invoice_T
where Invoice_Number = 4;
update Order_T
set Order_Quantity = 3
where Invoice_Number = 4;





-----------------------------------billing procedure--------------------------------------------------

create procedure billing(@invoice# as int,@customer# as int,@cust_name as Varchar(50),
@item_name as varchar(100),@order_quantity as integer,@phar_id as integer) AS
begin
insert into Customer_T
values (@customer#,@cust_name)
insert into Invoice_T(Invoice_Number)
values(@invoice#)
insert into Order_T(Invoice_Number,Item_Code,CustomerID,PharmacistID,Order_Quantity)
values(@invoice#,(select Item_T.Item_Code from Item_T where Item_Name =@item_name ),@customer#,@phar_id,@order_quantity)
update Item_T
set Item_Quantity = Item_Quantity - @order_quantity
where Item_Name = @item_name;
end
--drop procedure billing
exec billing @invoice# =4 ,@customer#=403,@cust_name ='Junaid' ,@item_name ='Tab. Antial 10mg',
@order_quantity= 10,
@phar_id = 318;











-----------------------------------PURCHASE REPORT VIEW--------------------------------------------------
create view Add_PURCHASE as
select Purchase_Receipt_T.ReceiptID,Purchase_Receipt_T.Purchase_Date,
Purchase_T.Item_Code,Item_T.Item_Name,Item_T.Item_Quantity,Item_T.Expiry_Date,
Item_T.Purchase_Price,Item_T.Sale_Price,Item_T.Item_Rack
,Purchase_T.VendorID,Vendor_T.Vendor_Name,Vendor_T.Vendor_Contact
FROM Purchase_Receipt_T,Purchase_T,Item_T,Vendor_T
WHERE Purchase_Receipt_T.ReceiptID = Purchase_T.ReceiptID
AND Purchase_T.Item_Code = Item_T.Item_Code
AND Purchase_T.VendorID = Vendor_T.VendorID;
--drop view Add_PURCHASE
-----------------------------------PURCHASE REPORT procedure--------------------------------------------------
create sequence vendor_id_seq AS int
start with 3200
increment by 1
create procedure Add_PURCHASE(@receiptid AS int,@itemcode AS int,
@vendorid AS int,@itemname AS Varchar(100),@quantity AS int,@expiry as date,@pur_price as int,
@sal_price as int,@rack AS INT,@vendorname AS varchar(50),@vendor_contact AS varchar(50)) as
begin 
insert into Item_T(Item_Code,Item_Name,Item_Quantity,Expiry_Date,Purchase_Price,Sale_Price,Item_Rack)
values(@itemcode,@itemname,@quantity,@expiry,@pur_price,@sal_price,@rack)
insert into Purchase_Receipt_T (ReceiptID)
values(@receiptid)
INSERT INTO Vendor_T
VALUES (@vendorid ,@vendorname,@vendor_contact)
insert into Purchase_T
values(@receiptid,@itemcode,@vendorid)
end
--drop procedure Add_PURCHASE

exec Add_PURCHASE @receiptid =112504,@itemcode = 112242,
@vendorid = 32189,@itemname = 'Tab. Neo_Antial',@quantity = 20,@expiry = '2024-09-01',
@pur_price  = 2,
@sal_price = 4,@rack = 5,@vendorname = 'Awais',@vendor_contact = '92-321-7541935'
-----------------------------------PURCHASE REPORT VIEW--------------------------------------------------
create view PURCHASE_REPORT as 
select Purchase_Receipt_T.ReceiptID,Purchase_Receipt_T.Purchase_Date,
Purchase_T.Item_Code,Item_T.Item_Name,Purchase_T.VendorID,Vendor_T.Vendor_Name
FROM Purchase_Receipt_T,Purchase_T,Item_T,Vendor_T
WHERE Purchase_Receipt_T.ReceiptID = Purchase_T.ReceiptID
AND Purchase_T.Item_Code = Item_T.Item_Code
AND Purchase_T.VendorID = Vendor_T.VendorID;
select* from PURCHASE_REPORT
-----------------------------------SALE REPORT VIEW--------------------------------------------------
CREATE VIEW SALES_REPORT AS
SELECT Invoice_T.Invoice_Number,Invoice_T.Invoice_Date,Order_T.Item_Code,Item_T.Item_Name,
Order_T.CustomerID,Customer_T.Customer_Name,Order_T.PharmacistID,Pharmacist_T.Pharmacist_Name
FROM Invoice_T,Order_T,Customer_T,Pharmacist_T,Item_T
WHERE Invoice_T.Invoice_Number = Order_T.Invoice_Number 
AND Order_T.Item_Code = Item_T.Item_Code
AND Order_T.CustomerID = Customer_T.CustomerID
AND Order_T.PharmacistID = Pharmacist_T.PharmacistID;
--------------------------------------------Item NAme VIEWS---------------------------------------------
create view item_name as 
select Item_T.Item_Name
from Item_T;
DROP VIEW item_name
---------------------------------------------VIEWS---------------------------------------------
--Create View Add_Item_View As
--Select Item_T.Item_Code, Item_T.Item_Name, Item_T.Item_Quantity,Item_T.Item_Rack_Number, Item_T.Purchase_Price, Item_T.Sale_Price, Item_T.Expiry_Date
--From Item_T;
--Select * From Add_Item_View;
DECLARE @NUM  INTEGER
SET @NUM = 10;
-----------------------------------billing procedure--------------------------------------------------

create procedure billing_cust_invoice(@invoice# as int,@customer# as int,@cust_name as Varchar(50)) AS
begin
insert into Customer_T
values (@customer#,@cust_name)
insert into Invoice_T(Invoice_Number)
values(@invoice#)
end
drop procedure billing
exec billing_cust_invoice @invoice# =4 ,@customer#=403,@cust_name ='Junaid' 





-----------------------------------billing procedure--------------------------------------------------

create procedure billing_items(@invoice# as int,@customer# as int,
@item_name as varchar(100),@order_quantity as integer,@phar_id as integer) AS
begin
insert into Order_T(Invoice_Number,Item_Code,CustomerID,PharmacistID,Order_Quantity)
values(@invoice#,(select Item_T.Item_Code from Item_T where Item_Name =@item_name ),@customer#,@phar_id,@order_quantity)
update Item_T
set Item_Quantity = Item_Quantity - @order_quantity
where Item_Name = @item_name;
end
drop procedure billing
exec billing @invoice# =4 ,@customer#=403 ,@item_name ='Tab. Antial 10mg',
@order_quantity= 10,
@phar_id = 318;