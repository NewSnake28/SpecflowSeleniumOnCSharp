Feature: Test1

A short summary of the feature

@tag1
Scenario: Login
	Given I am on the SwagLabsWebsite
	When I login
	And user clicks on Hamburger Icon
	And user navigates to HR Admin
	And user clicks on Status
	#And user clicks on Add Button
	#And user adds new status record
	And user copies status record
	And user saves status record
	Then toast success message is displayed
