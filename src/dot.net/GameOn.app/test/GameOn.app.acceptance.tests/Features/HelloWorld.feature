@acceptance.stage
Feature: Hello world
	To be made to feel at ease
	As a GameOn user
	I want the application to say hello to the world.

Scenario: Shows hello world message on startup
	Then the main window shows "Hello World!" as its message
