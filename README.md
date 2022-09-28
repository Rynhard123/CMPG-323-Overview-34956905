# CMPG-323-Overview-34956905
# Project1
## Repository
For the duration of this semester, I will complete all five projects using one repository. Testing each project using development branches before pushing the final updated version. By doing so I will use a basic folder structure to separate the different projects from each other
## Diagram of how repository and projects are integrated
![draw](https://user-images.githubusercontent.com/90310650/185113396-8d545781-d114-4a35-82e9-3d210c3d046d.PNG)
## Branching strategy to be used:
I will be using a simple branching strategy throughout the course of this semester. Using a simple branching strategy requires me to make future branches where I will update my project and test al bug fixes before applying them to main branch. Release branches will not be part of my strategy due to all bugs that needs to be fixed before the submission of projects, therefor I will use the idea of the release branches during testing then merging back to main branch for submission.
## How I will implement the .gitignore files
All projects are individual projects meaning all files will only be used by myself, therefor allowing me to ignore any files that are not currently in use by a project. This will avoid costly commits to files that shouldn’t be versioned. Some security files will also be ignored in order to keep sensitive information and credentials safe.
## Security
In the remainder of this semester, I will be using secrets as the main source to keep sensitive information and credentials. By doing so only collaborators will be able to have access to these secrets. In some cases, a Security.md file will be created and ignored as second way of keeping information safe.
# Project2
## Api and user information
Project2 is all about api’s. In this project we created different types of api methods like get, delete, put and post which all have different tasks they perform.
Api's can be used more than just data retrieval but as well as building programs.
In this program users should be authorized before being able to have access to api methods. Once Authorized users can manipulate database through the use of the different api methods.
## Azure
Azure was used in this project to Host our database and our api. Access to resource group was granted to moderators 
## GitHub
Source control was used as continuation of project1, to keep up 2 date with all our CMPG 323 work.
##Authorization
Our Database can only be accessed if users has the Database username and password.
All api endpoints also got their own authorization in order to use the api's. A token-based Authorization was used at all endpoints.
## References
https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0
https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-implementation
https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=06+Cmpg+323+-+Cloud+And+Api+Hosting+1+Sept.m4v
https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=05+CMPG+323+-+CLOUD+and+API+Security+25+August.mp4
https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/
https://www.tutorialsteacher.com/webapi/implement-get-method-in-web-api
https://www.c-sharpcorner.com/article/how-to-retrieve-data-from-database-in-asp-net-web-api-using-jquery/
https://auth0.com/docs/api/authentication#introduction
https://docs.microsoft.com/en-us/troubleshoot/sql/connect/network-related-or-instance-specific-error-occurred-while-establishing-connection
https://docs.microsoft.com/en-us/azure/traffic-manager/traffic-manager-manage-endpoints
https://stackoverflow.com/questions/46399015/could-not-parse-the-json-file-error-in-progam-cs-asp-net-core
https://docs.microsoft.com/en-us/azure/azure-sql/database/logins-create-manage?view=azuresql
https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=05+CMPG+323+-+API+Security+intro+23+Aug.mp4
https://docs.microfocus.com/SM/9.61/Hybrid/Content/database/concepts/retrieving_records_using_the_record_list_method.htm
https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/
Connection Strings - EF Core | Microsoft Docs
c# - More than one DbContext was found - Stack Overflow
Package Manager Console Commands | Learn Entity Framework Core
git - Remove directory from remote repository after adding them to .gitignore - Stack Overflow
# Project3
## How the Web Application works:
When the Web Application is first started, you will be loaded to the 'Home' screen. You will First need to register a user and the log in in order to access the Web Application. Once Loged in you can create new Zones and Categories and once they have been created you will be able to create a new device. Ps. Zones and Categories need to be created first in order to create a new device. You will be able to edit and delete data. There is also a logout option once you’re finished.
## Host of Web Application
The Web Application is Hosted on Azure with the Database created. The Database created is the same Database used in Project 2.
## Branches
I used Developmet-1 ass the branch during this project and once I finished the Project merged with my main branch.
## Security
All sensitive Information was not committed to GitHub and no information was stored in code.
## References
1.	https://www.c-sharpcorner.com/uploadfile/babu_2082/architectural-patterns-in-net/
2.	https://www.c-sharpcorner.com/UploadFile/bd5be5/design-patterns-in-net/
3.	https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview
4.	https://learn.microsoft.com/en-us/answers/questions/287457/web-apps-see-azure-sql-in-another-resource-group.html
5.	https://stackoverflow.com/questions/41233300/update-entity-class-in-asp-net-core-entity-framework
6.	https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1061?f1url=%3FappId%3Droslyn%26k%3Dk(CS1061)
7.	https://thecodeblogger.com/2021/05/04/how-to-use-appsettings-json-config-file-with-net-console-applications/
8.	https://stackoverflow.com/questions/24214860/entity-framework-an-error-occurred-while-updating-the-entries-see-the-inner
9.	https://docs.github.com/en/desktop/contributing-and-collaborating-using-github-desktop/keeping-your-local-repository-in-sync-with-github/syncing-your-branch
10.	https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=08+CMPG+323+-+Design+patternc+class+15+Sept.m4v
11.	https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=08+CMPG323+-+Project+3+-+WebApp+demo+13+Sept.m4v
12.	https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=09+CMPG323+-+Project+3+repository+pattern+concepts+20+Sept+recording.mp4
13.	c# - Should I worry about "This async method lacks 'await' operators and will run synchronously" warning - Stack Overflow
14.	GitHub - JacquiM/CMPG-323-IOT-Device-Management
15.	c# - 'object' does not contain a definition for 'X' - Stack Overflow
16.	Project 2 – ASP.Net Core Azure guidance documentation (On Efundi)
17.	Implementing Repository Pattern Guidance Document (On Efundi)




