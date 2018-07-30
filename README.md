# XamarinAndroidClickToAdd
Simple click-to-add-image for Xamarin.Android

<h2>Usage</h2>

Just click on the screen to start adding images to the layout. If you want to change to a button or something, change this:

```
ImageView image = new ImageView(this);
image.SetBackgroundResource(Resource.Mipmap.ic_launcher_round);
```

To something like this (for a `Button`):

```
Button button = new Button(this);
button.Text = "Some text";
button.SetBackgroundColor(Android.Graphics.Color.Red);
```

<h2>RelativeLayout</h2>

Remember to use a `RelativeLayout` to easily add your `Views` (elements) to the desired layout.

<h2>Built with</h2>

- [Visual Studio](https://visualstudio.microsoft.com/)

<h2>Authors</h2>

- [Gregory Perozzo](https://www.linkedin.com/in/perozzo/)

<h2>License</h2>

This project is under [MIT License](https://github.com/gperozzo/XamarinAndroidClickToAdd/blob/master/LICENSE).
