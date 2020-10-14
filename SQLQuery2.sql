Insert into Orders(Order_id, Order_sum, Order_date)
Values(17000, 948.5, '2018-09-10')
Select * From Orders

Select Order_sum
From Orders
Order by Order_sum Desc

Select Order_id
From Orders
Where Order_sum > 150

Select * From Orders
Where Order_date Like '2018-10%'

Insert into Orders(Order_id)
Values(18000)
Select * From Orders

Update Orders
Set Order_sum = 1000
Where Order_id = 17000
Select * From Orders

Delete From Orders
Where Order_id = 18000
Select * From Orders

Update Orders
Set Order_date = '2018-09-10'
Where Order_id = 17000
Select * From Orders

Update Orders
Set Order_user_id = 10000
Where Order_id in (15001, 15002, 16005) 

Update Orders
Set Order_user_id = 11000
Where Order_id in (16000, 17000) 
Select * From Orders

Select * From Orders o, Clients c
where o.Order_user_id = c.User_id


Select Count (Order_id)
From Orders o, Clients c
Where o.Order_user_id = c. User_id
and c.User_name = 'John'

Select Sum (Order_sum)
From Orders o, Clients c
Where o.Order_user_id = c. User_id
and c.User_name = 'Kate'

Select Top 2 (Order_id)
From Orders o, Clients c
Where o.Order_user_id = c. User_id
and c.User_name = 'John'
Order by Order_id Desc