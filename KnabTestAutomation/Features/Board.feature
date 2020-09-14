Feature: Board operations
	In order to check that CRUD operations on board are working
	As a Trello user
	I want to make sure that I can manage the cards

Scenario: Create a new card
	Given the Trello homepage is displayed
	And I click the login link
	When I enter a username and password
	| Username | Password     |
	| rolando.de.boer@the-future-group.com | sRmvSYkryib7 |
	And I click the login button
	And I open a board