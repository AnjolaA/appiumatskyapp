Feature: SignIn
	In order to use the app
	As a sky user
	I want to login

@mytag
Scenario: Sign in
	Given I  login with valid details "zero\aaw05" and "Password1" 
	Then I have access to the pages in the app
