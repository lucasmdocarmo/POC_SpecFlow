Feature: Rental
	In Order to Rent a Car,
	Have a Drivers Licence,
	Have Credit,
	And,
	Car Must Exist

@Rent
Scenario: Rent a Car
	Given Existing Client
	And Client has Driver Licence 
	When Client Rents the Car
	Then the result should be True
