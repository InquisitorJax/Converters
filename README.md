# Xamarin.Forms Community Toolkit: Converters
Value converters for Xamarin.Forms

### Build status:
* [![Build status](https://ci.appveyor.com/api/projects/status/a2a4mah2fk8xicm7/branch/master?svg=true)](https://ci.appveyor.com/project/FormsCommunityToolkit/converters/branch/master)
* Private NuGet Feed: https://ci.appveyor.com/nuget/fct-converters

### Available Converters
These are the current value converters available in the toolkit

#### BooleanToObjectConverter
Takes a bool and coverter is to any object you need.

```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:BooleanToObjectConverter  x:Key="BooleanToObjectConverter" x:TypeArguments="Style">
			<toolkit:BooleanToObjectConverter.FalseObject>
			  <Style TargetType="Image">
				<Setter Property="Source" Value="{local:ImageResource Samples.Images.error.png}" />
			  </Style>
			</toolkit:BooleanToObjectConverter.FalseObject>

			<toolkit:BooleanToObjectConverter.TrueObject>
			  <Style TargetType="Image">
				<Setter Property="Source" Value="{local:ImageResource Samples.Images.success.png}" />
			  </Style>
			</toolkit:BooleanToObjectConverter.TrueObject>
		  </toolkit:BooleanToObjectConverter>
		</toolkit:BooleanToObjectConverter/>
     </ResourceDictionary>
    </ContentPage.Resources>

	 <Image Style="{Binding IsValid, Converter={StaticResource BooleanToObjectConverter}}"/>
</ContentPage>
```

#### HasDataConverter
Checks to see if value is null, if a string has data, and if an IList has any items.


```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:HasDataConverter x:Key="HasDataConverter"/>
     </ResourceDictionary>
    </ContentPage.Resources>

	<ListView IsVisible="{Binding FollowItems, Converter={StaticResource HasDataConverter}}">
	</ListView>
</ContentPage>
```

#### HexToColorConverter
Takes in a string hex and coverts to a Xamarin.Forms color


```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:HexToColorConverter x:Key="HexToColorConverter"/>
     </ResourceDictionary>
    </ContentPage.Resources>

	<Label TextColor="{Binding ColorBinding, Converter={StaticResource HexToColorConverter}}">
</ContentPage>
```

#### InvertedBooleanConverter
Inverts that bool!


```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:InvertedBooleanConverter x:Key="InvertedBooleanConverter"/>
     </ResourceDictionary>
    </ContentPage.Resources>

	<!--Only show when not busy-->
	<ListView IsVisible="{Binding IsBusy, Converter={StaticResource InvertedBooleanConverter}}">
	</ListView>
</ContentPage>
```

#### LowerTextConverter
Lowercases the text given.


```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:LowerTextConverter x:Key="LowerTextConverter"/>
     </ResourceDictionary>
    </ContentPage.Resources>

	<Label Text="{Binding Name, Converter={StaticResource LowerTextConverter}}">
</ContentPage>
```

#### UpperTextConverter
Uppercases the text given.


```xaml
<ContentPage 
   xmlns:toolkit="clr-namespace:FormsCommunityToolkit.Converters;assembly=FormsCommunityToolkit.Converters">
    <ContentPage.Resources>
     <ResourceDictionary>
        <toolkit:UpperTextConverter x:Key="UpperTextConverter"/>
     </ResourceDictionary>
    </ContentPage.Resources>

	<Label Text="{Binding Name, Converter={StaticResource UpperTextConverter}}">
</ContentPage>
```