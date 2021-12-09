# Car-Sharing application ~ Hungarian 🚗🌍

![app_gif](images/app.gif)

## Introduction

This application was one of my university assignments, it's basically a car-sharing/car-pooling `MVC` application containing

- `Guest` functions
- `User` functions
- `Admin` functions

**Carpooling** (also car-sharing, ride-sharing and lift-sharing) is the sharing of car journeys so that **more than one person travels in a car**, and prevents the need for others to have to drive to a location themselves.



![img.png](images/img.png)

![img_1.png](images/img_1.png)

![img_4.png](images/img_4.png)

![img_2.png](images/img_2.png)

![img_3.png](images/img_3.png)

## Launching

- It's complex, I haven't figured out yet


- Data Connections - right click - Add Connection
- Browse the `Database1.mdf` (can be found in the project folder)
- Press <b>OK<b>

![img.png](images/run1.png)

![img_3.png](images/run2.png)

- Tools - NuGet Package Manager
- Package Manager Console
- `Scaffold-DbContext "here you paste the connection string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context PatientDB`
- Press Enter

![img_1.png](images/run3.png)

- If red notification occurs, paste the command again with `-Force` at the end

![img_2.png](images/run4.png)

- The program is connected to the database but will not work properly.

<br>
<br>
<br>