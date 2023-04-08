Feature: Test2

A short summary of the feature

@tag1
Scenario: Login
	Given I am on the Magento website
	When I click on the My Account link
	Then I should be on the <Title> page
	When I enter login credentials with email <Email> and password <Password>
	Then I should be on the My Account page


	Examples:
	| Email                 | Password               | Title          |
	| roni_cost@example.com | roni_cost3@example.com | Customer Login |


@tag2
Scenario: Search
	Given I am on the Magento website
	When I enter search term <SearchTerm> and search
	Then I should be on the search page <SearchTerm>

	Examples:
	| SearchTerm |
	| fitness    |
	| laptop     |


@tag3
Scenario: Add to cart
	Given I am on the Magento website
	When I enter search term <SearchTerm> and search
	Then I should be on the search page <SearchTerm>
    When I click on the <Product> in the list
	And I click on the Add to Cart button
	And I click on the shopping cart button
	And I click on the view and edit cart button
	Then I should be on the shopping cart page with <Title>

	Examples:
	| SearchTerm | Product | Title         |
	| fitness    | 1       | Shopping Cart |
	| fitness    | 3       | Shopping Cart |