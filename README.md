#P Diffy
##A perceptual difference image tool.

![alt text](https://github.com/SeatwaveOpenSource/pdiffy/blob/master/pdiffy_logo.PNG "P Diffy")

##Running the web app
1. Clone this repo
2. Restore Nuget Packages
3. Run this using Visual Studio (2013 or later) or host it somewhere **(run it as an admin)**
4. **(This step is required if you don't give P Diffy all the required permissions)** Add the environment variables *pdiffyImageStorePath* and *pdiffyDataStorePath* and set the values to wherever you want to store the images and data P Diffy requires

##Using P Diffy

There are two ways to generate difference images using P Diffy.

1. Host the images yourself.
--
Endpoint: **/api/page/update?name=nameofcomparison&imageUrl=yourimageurl**

* The first time you hit this endpoint with an image url P Diffy will create the base for future comparisons.
* The second time you hit this endpoint with an image url P Diffy will compare the image at the given url with the image at the original url and generate a difference image if necessary.

2. Let P Diffy host the images.
--
Endppoint: **/api/page/update?name=nameofcomparison**

This endpoint requires the image that will be compared to be streamed to it. (see example below)

```csharp
var request = HttpWebRequest.Create("//yourhosting.something/api/page/upload?name=nameofcomparison");
request.Method = "POST";
var stream = request.GetRequestStream();
var docFile = File.OpenRead(@"C:\Images\unicorn.png");
docFile.CopyTo(stream);
docFile.Close();
stream.Close();
var response = request.GetResponse();
```

* The first time you hit this endpoint with a streamed image P Diffy will store the image and create the base for future comparisons.
* The second time you hit this endpoint with streamed image P Diffy will save the newly streamed image and compare it to the orignal image, creating a difference image if necessary.

##Urls

* **http://yourhosting.something**
* **http://yourhosting.something/api/update?name=nameofcomparison&imageUrl=yourimageurl**
* **http://yourhosting.something/api/update?name=nameofcomparison**
