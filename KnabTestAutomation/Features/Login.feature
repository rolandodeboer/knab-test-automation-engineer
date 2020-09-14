Feature: Login
	In order to check that the login validations are working
	As a Trello user
	I want to make sure that I can only login with valid credentials

@assesment @positive @smoke
Scenario: Login with valid credentials
	Given the Trello homepage is displayed
	And I click the login link
	When I enter a username and password
	| Username | Password     |
	| rolando.de.boer@the-future-group.com | sRmvSYkryib7 |
	And I click the login button
	Then I should see the Trello board overview