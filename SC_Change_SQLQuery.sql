alter table dishdetails
add dishid int primary key not null identity(1,1)

ALTER TABLE dishdetails
ADD UNIQUE (dish_name)

alter table invoice
add invid int primary key not null identity(1,1)

alter table order_costing
add ordcostingid int primary key not null identity(1,1)

alter table Orders
add ordrid int primary key not null identity(1,1)

create table paymentlog(
logid int primary key identity(1,1),
loginvnum varchar(55) foreign key references customer(cus_id),
loginvdate date,
loginvtotal int,
logcashrec int,
logdiscount int,
logbalance int
)


create table logins(
userid int primary key identity(1,1),
username varchar(50) not null,
upassword varchar(50) not null,
userrole varchar(50) not null
)

//------------------ Working with Noman Sir for add Deals Items 09-February-2022 ---------------//

create table deals(
dealid int primary key identity(1,1),
dealname varchar(255),
dealprice money,
isactive bit
)

create table additem_deal(
id int primary key identity(1,1),
deal_id int foreign key references deals(dealid),
item_id int foreign key references dishdetails(dishid),
item_qty int
)

select deals.dealname,dishdetails.dish_name,additem_deal.item_qty,deals.dealprice from deals 
inner join additem_deal on deals.dealid = additem_deal.deal_id
inner join dishdetails on dishdetails.dishid = additem_deal.item_id


select * from logins
------insert into logins (username,upassword,userrole) values ('muzaffar','3303906967','user')
------insert into logins (username,upassword,userrole) values ('yousuf','03329222593','administrator')


//------------------ Altration in Query Payment LOG for Number and Customer Final Balance on 26-December-2021---------------//


alter table paymentlog
add cusnumber varchar(20)

alter table paymentlog
add cusfinalbalance int

//------------------ Altration in Query Payment LOG for Number and Customer Final Balance on 05-February-2022---------------//

alter table paymentlog
add logmode varchar(500)

alter table paymentlog
add log_pay_Status varchar(600)

alter table invoice
add GST decimal

alter table dishdetails
add foodcatagory varchar(500)



select i.invoicenum,i.invoice_date,i.invoice_value,p.logcashrec,p.logdiscount,p.logbalance,p.cusfinalbalance
from invoice i, paymentlog p
where i.invoicenum = p.loginvnum
and p.cusnumber = '03329222593'

select DISTINCT cus_name,cus_phonenum,cus_address from customer where cus_phonenum = '03329222593'


select i.invoicenum,i.invoice_date,i.invoice_value,p.logcashrec,p.logdiscount,p.logbalance,p.cusfinalbalance
from invoice i, paymentlog p
where i.invoicenum = p.loginvnum
and p.cusnumber = '03329222593'
and i.invoice_date between '2021-12-10' and '2021-12-26'

select SUM(i.invoice_balance) as Balance,MIN(i.invoice_date) as inv_start,MAX(i.invoice_date) as inv_end
from invoice i, customer c
where i.invoicenum = c.cus_id
and c.cus_phonenum = '03329222593'
and i.invoice_date < '2021-12-26'


select customer.cus_id,customer.cus_name,customer.cus_address,invoice.invoice_date,invoice.invoice_value,invoice.invoice_adv,invoice.invoice_disc,invoice.invoice_balance,invoice.Costing
from invoice left join customer  on invoice.invoicenum = customer.cus_id where invoice.invoice_date between '2021-12-01' and '2021-12-26'
order by cus_id desc

select MIN(invoice.invoice_date) as St_Date, MAX(invoice.invoice_date) as End_Date
from invoice left join customer  on invoice.invoicenum = customer.cus_id where invoice.invoice_date between '2021-12-01' and '2021-12-26'

select SUM(invoice.invoice_value) as Inv_Value, SUM(invoice.Costing) as Costing, SUM(invoice.invoice_balance) as Credit
from invoice left join customer  on invoice.invoicenum = customer.cus_id where invoice.invoice_date between '2021-12-01' and '2021-12-26'


//------------------ Extra Requirement Opening of SC on 06-March-2022---------------//


select order_date,order_itemname,sum(order_qty) as Qty,sum(order_itemperunitrate) as Amount 
from Orders where order_no like 'SCCS%' and order_date = '2022-03-06' 
group by order_date,order_itemname 

select sum(order_itemperunitrate) as Amount 
from Orders where order_no like 'SCCS%' and order_date between '2022-03-06' and '2022-03-06'





