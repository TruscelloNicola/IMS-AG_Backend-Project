
# DeerDiary

## IMS AG Sidenote
The current reposity is a **cut-down** version of the handed-in project. It includes only the backend, which has been developed solely by myself, with the exception of the hashing algorythm.

Please keep in mind this project is **not completed**. Due to the **recent hand-in** for the project **(11.11.24)**, I did not have the time to improve the backend to a state of sufficiency by my standards.

Swagger is only to be used as an overview, requests are preferably made through dedicated API-Interface testing applications like Insomnium or Postman.

## Concept and Planning
### Idea
DeerDiary is an application which helps you Journal. Each day you visit the site, where you may write down a simple entry about your day. DeerDiary asks a random question each day, to help you engage and express your emotions. Not only that, it mentors you specifically to your journal entries, by reading the journal and asking specific questions to help you see what is not clear. The goal is to help you express.
#### Originality
DeerDiary seeks to improve QoL when journaling and most importantly support you with your expression, by asking questions specifically to your journal entries.  
### Technologies
#### Frontend -- REMOVED
We will employ Blazor as our frontend, where it is independent of the backend and communicates through the API to the backend.
#### Backend
We will employ ASP.NET as our backend, where it connects to the DB and offers an API. Entity framework will be used as an ORM.
#### Database
We will employ a MySQL database which will be running inside a container.

## First time setup
### Docker setup
- Ensure that there is no previous instance of the MySQL container, otherwise delete the previous instance in order to achieve uniformity.
- `docker compose up` inside of the repository to start up all the containers needed for the Website.
### Database setup
- In the Package Manager Console (PM) of Visual Studio, execute `update-database`.

The first time setup is complete.

## Starting the project

After following the aforementioned steps, each startup of the backend can be executed without the need of the previous first time setup steps.