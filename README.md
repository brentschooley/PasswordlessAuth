# Passwordless Authentication Using Twilio SMS and ASP.NET MVC

This project is an ASP.NET MVC port of the passwordless authentication system written by Ricky Robinett [in this blog post](https://www.twilio.com/blog/2015/01/mobile-passwordless-sms-authentication-part-1-building-the-api-with-laravel-and-twilio.html).

## Setup

For this backend you'll need a [Twilio](http://twilio.com) account that can send and receive SMS messages - [create one free here](http://twilio.com/try-twilio).

Before running the application you'll need to edit the Web.config file to set up some application settings:

``` xml
<add key="TwilioAccountSid" value="*** Your Twilio AccountSid ***"/>
<add key="TwilioAuthToken" value="*** Your Twilio Auth Token ***"/>
<add key="TwilioPhoneNumber" value="*** Your Twilio Phone Number ***"/>
<add key="YourEmailAddress" value="*** Your Email Address ***"/>
<add key="YourCellphoneNumber" value="*** Your Cellphone Number ***"/>
```

The Twilio information will be used to send authentication tokens via SMS. Your email address and cellphone number will be used to create a User model object during the migration process' Seed method. Make sure to run `Update-Database` from the Package Manager Console to apply the Entity Framework Migrations before running.

<a href="https://azuredeploy.net/" target="_blank"><img src="http://azuredeploy.net/deploybutton.png"/></a>

## Meta

* No warranty expressed or implied. Software is as is.
* [MIT License](http://www.opensource.org/licenses/mit-license.html)
* Made with ♥ by [Twilio](http://twilio.com) Philly
