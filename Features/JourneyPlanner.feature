Feature: Journey Planner - To verify the journey planner app on the Tf


Scenario: Valid journey
	Given the user navigates to the tfl home page
	When click on accept all the cookie button
	And I enter "London Bridge" in the from field
	And I enter "Victoria" in the to field
	And I click plan my journey button
	Then The results page with "Journey results" is displayed
	And the map is diplayed
	

Scenario: Empty fields
	Given the user navigates to the tfl home page
	When click on accept all the cookie button
	And I click plan my journey button
	Then I should see error message "The From field is required." on the from field
	Then I should see error message "The To field is required." on the to field

Scenario: Invalid journey
	Given the user navigates to the tfl home page
	When click on accept all the cookie button
	And I enter "vvv" in the from field
	And I enter "vvv" in the to field
	And I click plan my journey button
	Then The results page with "Journey results" is displayed
	And I should see "Sorry, we can't find a journey matching your criteria" error message on journey results
	

Scenario: Check time options and edit
	Given the user navigates to the tfl home page
	When click on accept all the cookie button
	And I click on change time
	And I click on the "Arriving" option
	When I select "Tomorrow" as a date
	And I Select "11:30" as a time
	And I enter "London Bridge" in the from field
	And I enter "Victoria" in the to field
	And I click plan my journey button
	Then The results page with "Journey results" is displayed
	When I click on edit journey
	And I click on the "Leaving" option
	When I select "Today" as a date
	And I Select "21:00" as a time

Scenario: Recents
	Given the user navigates to the tfl home page
	When click on accept all the cookie button
	And I enter "London Bridge" in the from field
	And I enter "Victoria" in the to field
	And I click plan my journey button
	Then The results page with "Journey results" is displayed
	When I click on the tfl logo
	And I click on "Recents" tab
	Then I click on journey number 1 