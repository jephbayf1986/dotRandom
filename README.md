# dotRandom

dotRandom is a quick and simple Random Generator for testing in Dot Net!

## How to Use

### Installation

You can install dotRandom from Nuget Package Manager, or Nuget CLI:

```cli
nuget install dotRandom
```

Or you can use the dotnet cli:

```cli
dotnet add package dotRandom
```

### General Use

Generating a random number:

```cs
var randomLong = DotRandom.RandomLong();

var randomInt = DotRandom.RandomIntBetween(10, 1000);

var randomNegative = DotRandom.RandomNegativeInt();

var randomShort = DotRandom.RandomPostitiveShort();

var randomByte = DotRandom.RandomByteBetween(10, 100);
```

Generating a random string:

```cs
var randomString = DotRandom.RandomString();

var anotherRandomString = DotRandom.RandomString(length: 20);

var upperCase = DotRandom.RandomUpperCaseString();

var lowerCase = DotRandom.RandomLowerCaseString();
```

Generating a random date:

```cs
// Optional Parameter "maxDaysInPast"
var dateInPast = DotRandom.RandomDateInPast(maxDaysInPast: 20);

// Optional Parameter "maxDaysInFuture"
var dateInFuture = DotRandom.RandomDateInFuture(maxDaysInFuture: 10);

var dateIn2022 = DotRandom.RandomDateInYear(2022);

var randomTimeToday = DateTime.Today.WithRandomTime();
```
