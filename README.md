# CodeChalenge
Create a simple CRUD application with ASP NET Core that implements the below 
models:
Customer {
Firstname
Lastname
DateOfBirth
PhoneNumber
Email
BankAccountNumber
Addresses (List of Address)
}
Address {
CountryTitle
CityTitle
PostalCode
Street
}

Practices and patterns :
• DDD
• Clean architecture
• Clean git commits that shows your work progress.

The project layers are as described below: 
This project is create in Clean architecture so it has domain layer for base mode and bahviour .
The dbcontext and migrations located at persitance project as persitance layer.
The unit test uses mock for test dbconext crud operations of customers.
The prsentations is as a swagger output for showing the crud api of Custmoer entities .
