# Sitecore Rules Demo
Demonstration of Sitecore Rules Engine

Let your mind relax.  Breathe in slowly through your nose.  Exhale slowly through your mouth.  Your mind is a calm pond.

** The Business Problem **

Your company, Demo LLC, has folks who visit across the Eastern Seaboard.  Your company is still small but slowly growing West.

To provide the best user experience, you want to welcome users from various states with mementos of those states because user testing
has indicated that users are much more likely to hang out on your site if they feel more like it's home.

Somewhat new to Sitecore and well versed in ASP.NET MVC, you embark on what most of us have done new to Sitecore and you create a view for your welcome banner much like the code here

<code>
@model MyAwesomeSolution.Models.UserGeolocationModel

@if ( User.Geolocation.State == "VA")
{
    
    Model.Location.Text = "Old Dominion";
    Model.Location.ImageUrl = "/media/herobackgrounds/olddominion.png";
}else if ( User.Geolocation.State == "NC" )
{
    
    Model.Location.Text = "Nawth Kackalacka";
    Model.Location.ImageUrl = "/media/herobackgrounds/charlottespeedway.png";
}
else if ( User.Geolocation.State == "NY" )
{
    
    Model.Location.Text = "Fuhgit About It";
    Model.Location.ImageUrl = "/media/herobackgrounds/angrycabbie.png";
}
else
{
    
    // Don't render at all if not VA, NC or NY
    Model.RenderHero = false;
}
</code>

If we're in ASP.NET MVC land, there's nothing overly wrong with this code, especially if we have no means to data drive the view.  In Sitecore, business logic in the view is a prime candidate for Conditional Renderings or better yet, Sitecore Personalization.

I invite you to pull the code down, take a peek, complain at my humble somewhat futile attempts at styling a Hero, laugh at my Text-Shadow styling and pay really close attention to the personalization rule and its use.
This is truly just scratching the tip of the iceberg but I hope it's an eye opener for you in terms of how to better leverage Sitecore Personalization.
Please note the following:

1) In Sitecore 8.0 Analytics must be enabled to use any Personalization

2) In Sitecore 8.1 Update 3, the Tracker must be active (this tracks the visitor).  If SamplingRate is < 100%, your personalization rules will not fire for people who fall outside of the Sampling Rate.

    -- Sitecore has filed this as a bug.
