Feature: Test1

Swag Labs website
All tests are run independently from each other

@tag1
Scenario: Login
	Given I am on the SwagLabs website
	When I login with username <Username> and password <Password>
	Then Swag Labs should be displayed


	Examples:
	| Username                | Password     |
	| standard_user           | secret_sauce |
	| locked_out_user         | secret_sauce |
	| problem_user            | secret_sauce |
	| performance_glitch_user | secret_sauce |

@tag2
Scenario: Logout
	Given I am on the SwagLabs website
	When I login with username <Username> and password <Password>
	Then <Title> should be displayed
	When I click on the hamburger icon
	And I click on Logout
	Then <Title> should be displayed

	Examples:
	| Username                | Password     | Title     |
	| standard_user           | secret_sauce | Swag Labs |
	| problem_user            | secret_sauce | Swag Labs |
	| performance_glitch_user | secret_sauce | Swag Labs |
	
@tag3
Scenario: Sorting
	Given I am on the SwagLabs website
	When I login with username <Username> and password <Password>
	Then <Title> should be displayed
	When I click on the <Filter> icon and choose an <Sort> option

	Examples:
	| Username      | Password     | Title     | Filter                 | Sort |
	| standard_user | secret_sauce | Swag Labs | product_sort_container | 1    |
	| standard_user | secret_sauce | Swag Labs | product_sort_container | 2    |
	| standard_user | secret_sauce | Swag Labs | product_sort_container | 3    |
	| standard_user | secret_sauce | Swag Labs | product_sort_container | 4    |
	
@tag4
Scenario: Add to cart
	Given I am on the SwagLabs website
	When I login with username <Username> and password <Password>
	Then <Title> should be displayed
	When I click on <Product> button to add to cart
	And I click on cart icon
	Then <Title> should be displayed

	Examples:
	| Username      | Password     | Title     | Product                              |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-backpack      |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-fleece-jacket |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-bike-light    |
	
@tag5
Scenario: Checkout Cart
	Given I am on the SwagLabs website
	When I login with username <Username> and password <Password>
	Then <Title> should be displayed
	When I click on <Product> button to add to cart
	And I click on cart icon
	Then <Title> should be displayed
	When I click on checkout button
	Then <Title> should be displayed
	When I continue with firstname <Firstname> and lastname <Lastname> and postalcode <Postalcode>
	Then <Title> should be displayed
	When I click on the checkout finish button
	Then <Title> should be displayed

	Examples:
	| Username      | Password     | Title     | Product                              | Firstname | Lastname | Postalcode |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-backpack      | Test      | Testing  | 12345      |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-fleece-jacket | Test      | Testing  | 12345      |
	| standard_user | secret_sauce | Swag Labs | add-to-cart-sauce-labs-bike-light    | Test      | Testing  | 12345      |