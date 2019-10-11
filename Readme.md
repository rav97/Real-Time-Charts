#Real-time Charts
Powyższy program ma za zadanie rysować w czasie rzeczywistym wykresy funkcji Sin(t), gdzie t oznacza czas wyrażony w sekundach od momentu uruchomienia programu, oraz nałożony na nią szum o rozkładzie Gaussa. Program napisany przy użyciu języka C# oraz API Windows Forms.

##Wykorzystane narzędzia i biblioteki
###Narzędzia
+ Visual Studio 2017

###Biblioteki
+ .Net Framework 4.7.2
+ [MathNet.Numerics.Distributions](https://numerics.mathdotnet.com/api/MathNet.Numerics.Distributions/)

##Kompilacja i uruchomienie
W celu uruchomienia programu, sklonuj lub pobierz repozytorium, a następnie uruchom w środowisku Visual Studio 2017 lub nowszym. Upewnij się, że posiadasz platformę .Net Framework w wersji 4.7.2 lub nowszej. Pakiet Math.Net powinien być zainstalowany. W razie problemów można go zainstalować przy użyciu mechanizmu NuGet.
Program można uruchomić w trybie debugowania lub bez przy użyciu klawisza F5 (lub Ctrl+F5 w trybie bez debugowania).

##Działanie programu
Program generuje w czasie rzeczywistym wykres funkcji Sin(t) oraz nałożonego na nią szumu Gaussowskiego. Użytkownik ma możliwość ustalenia amplitudy tych funkcji. A także średniej i odchylenia standardowego rozkładu normalnego.
1. Naciśnięcie przycisku "Start!" powoduje rozpoczęcie generowania wykresów funkcji.
2. Naciśnięcie przycisku "Stop!" zatrzymuje rysowanie wykresów
3. Możliwe jest zmodyfikowanie amplitudy, średniej oraz odcyhlenia standardowego generowanych wykresów.

##Wygląd programu
![](https://i.ibb.co/RT47p30/Realt-time-charts.png)

##Czas pracy nad programem
Prace nad przygotowanien programu składały się z następujących czynności i wymagały nakładu pracy odpowiednio:

Czynność | Czas 
------------- | -------------
Zapoznanie się z poleceniem i zebranie niezbędnych informacji.  | 45 min
Zaprogramowanie rysowania funkcji w czasie rzeczywistym.  | 25 min
Zabezpieczenie programu przed błędami. | 15 min
Testy. | 30 min


# Real-time Charts
This program is designed to draw real-time graphs of the function Sin (t), where t is the time expressed in seconds from the moment the program is started, and the Gaussian noise imposed on it. Program written using C # language and the Windows Forms API.

## Used tools and libraries
### Tools
+ Visual Studio 2017

###Libraries
+ .Net Framework 4.7.2
+ [MathNet.Numerics.Distributions] (https://numerics.mathdotnet.com/api/MathNet.Numerics.Distributions/)

## Compilation and launching
To run the program, clone or download the repository, and then run in Visual Studio 2017 or newer. Make sure you have the .Net Framework version 4.7.2 or newer. The Math.Net package should be installed. In case of problems, it can be installed using the NuGet mechanism.
You can run the program in debug mode or without it using the F5 key (or Ctrl + F5 in non-debug mode).

## Program operation
The program generates a real-time graph of the Sin (t) function and the Gaussian noise imposed on it. The user can set the amplitude of these functions. And also the mean and standard deviation of the normal distribution.
1. Pressing the "Start!" starts generating function graphs.
2. Pressing the "Stop!" stops drawing charts
3. It is possible to modify the amplitude, average and standard deviation of the generated graphs.

## Appearance of the program
! [] (Https://i.ibb.co/RT47p30/Realt-time-charts.png)

## Time spent working on the program
The work on the preparation of the program consisted of the following activities and required work input, respectively:

Action | Time
------------- | -------------
Gathering necessary information. | 45 min
Programming function drawing in real time. | 25 min
Error protection. | 15 min
Testing. | 30 minutes