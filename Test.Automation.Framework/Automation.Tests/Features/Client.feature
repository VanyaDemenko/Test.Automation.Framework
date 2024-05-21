Feature: Client

Client Regression Scenarios

@Smoke
Scenario: User can create the Client with the correct data
	When I create a new client via API
		| Id | Name |
		| 1  | test |
	Then The last response status code 'should' be equal to '200'
	And The Client response 'has' the following data
		| Name | Age | Adi           |
		| test | 1   | addition_info |