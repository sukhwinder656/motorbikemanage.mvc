﻿Add-Migration motorbike -context ApplicationDbContext
Update-Database motorbike -context ApplicationDbContext
Add-Migration racingbike -context motorbikemanagemvcContext
Update-Database racingbike -context motorbikemanagemvcContext