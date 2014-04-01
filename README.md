ASPNetMVC53rdPartyAuth
======================

ASP .Net MVC5 3rd Party Authentication using Facebook, Google &amp; Twitter and Microsoft Live Account. 

This uses the ASP.NET MVC5 with Bootstrap 3.1.1 LESS1 and OWIN http://owin.org/

Changes need to be made in Startup.Auth.cs to integrate the 3rd Party Authentication services. 

This is very straightforward, just need to use the OWIN interface to call the 3rd party Authentication services 
you like to integrate and framework take cares of everything. Only tricky part is, you have to register
your app with respective services which is not necessrily straightforward. 


Google:
-------
Easiest to implement, just need to enable the service, works like a charm. 

Microsoft:
--------------
You have to register this app at https://account.live.com/developers/applications and get the clientId and clientSecret.
There are some latency and availabilty issue with live authentication service. 

Twitter:
---------
You have to register this app at https://apps.twitter.com/ and get the consumerKey(API key) and consumerSecret(API secret).    
Twitter requires valid url format otherwise it won't work. But it can be placeholder values. 
So website need to be set at http://xxx.com format(i.e http://www.example.com) 
and Callback URL at http://xxx.com/twitter/callback format (i.e. http://www.example.com/twitter/callback)

Facebook:
---------
You have to register this app at https://developers.facebook.com/ and get the appId and appSecret.   
Facebook requires SSL, so that need to be enanbled.  
Project url can be found under project properties and can be localhost.

