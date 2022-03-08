Select Customers.CustomerId, OrderType, EligibleToWin, Won 
	from Customers, Orders 
	where Customers.CustomerId = Orders.CustomerId