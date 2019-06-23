# Dexterity.Login
An Identity Provider (IDP)

A proof of concept combination of ASP.NET Core Identity as an authentication provider and Identity Server 4 as an authorisation provider.

The intention is to develop a simple "login" site which will allow users to register a new account (via ASP.NET Core Identity) and log into that account (via an Identity Server 4-supported Hybrid flow) to update their profile details. This site will act as an Identity Provider (IDP) for future client applications to be secured against.

*Note that this is strictly a proof of concept, learning exercise for me at the moment. Don't expect much in the way of quality and definately don't trust any of this stuff in a production environment. You have been warned!*

## TODOs
* Add log out functionality.
* Develop new minimal "register new user" and "login and logout user" pages based on what I've learnt so far.
* Start to phrase out the scaffolded bits of ASP.NET Core Identity and Identity Server 4 quickstart UIs when I'm confident I know what they did and that I don't need them anymore.
* Create another application or service to secure against this IDP as a client and verify it works.
