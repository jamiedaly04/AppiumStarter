Feature: Login
Check that the Login Page is working as expected

@SmokeTest
Scenario: Login with Site User
	Given Im at the Login screen
	When I Enter Valid instance details with Login Credentials
		| Instance | Email              | Password  |
		| Staging2 | TestAutomationUser | m51t3P@$$ |
	Then I can Successfully Login



