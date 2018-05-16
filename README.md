# PubNubTest
This is a sample app demonstrating publish-subscribe service of Pubnub


![Demo](https://github.com/alshell7/PubNubTest/blob/master/PubNubTest/Demo.PNG "Demo")

## Getting Started
* Download latest Pubnub library for .NET 

  `PM> Install-Package Pubnub -Version 4.0.16 `
  > (Latest version as of May-2018)
  
  Or, update the packages for the project
  
  `nuget update PubNubTest.sln`
 
* Head over to Pubnub's [Developer Console](https://admin.pubnub.com/) and create a new app with any name
* Having a KeySet created, Copy `Publish Key`, `Subscribe Key` and the `Secret Key`
* Fill the below fields found in this [class](https://github.com/alshell7/PubNubTest/blob/master/PubNubTest/Form1.vb)
with the keys you copied respectively in the above step

  ```
    Private ReadOnly PublishKey As String = ""
    Private ReadOnly SubscribeKey As String = ""
    Private ReadOnly SecretKey As String = ""
  ```
* Build the project and run two instances of the executable generated, each for as Sender and Receiver application
* Press `Subscribe` button on the instance application that should act as Receiver
> Make sure the channel name is not empty and is same for both of the instances
* In the other instance of application, which is now a Sender, Type in the `Message To Send` field and press `Publish`
* The message appears in Receiver instance of the application
