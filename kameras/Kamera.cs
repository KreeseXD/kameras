using System.Xml.Serialization;
using StardewValley;

namespace Kamera;


// used StardewValley.Tools.FishingRod as a refernce
// https://stardewvalleywiki.com/Modding:Tools
public class Kamera : StardewValley.Tools.GenericTool
{
    public const int FilmIndex = 0;
    public const int LensIndex = 0;

    // 36 exposures, but can move this to a yml file for half frame rolls/ 24 frame
    public static int maxFilmUses = 36;

    [XmlIgnore]
    public bool isTakingPhoto;

    [XmlIgnore]
    public bool doneWithAnimation;

    public static ICue takePhotoSound;

    public static ICue reelFilmSound;

    // not sure how this is being used in FishingRod.cs
    // looks like a state flag?
    [XmlIgnore]
    public bool hasDoneFucntionYet;

    // GenericTool.cs doesn't have a constructor, going to use grandparent constructor here
    // might not even be the right way to do this
    // fuck it
    public Kamera()
    {
        // wtf is this even doing
        initNetFields();
        base.Category = -99;

        Name = "kamera";
        SetSpriteIndex(189);
        IndexOfMenuItemView = 8;
        AttachmentSlotsCount = Math.Max(0, 2);
        base.Category = -99;
        UpgradeLevel = 0;
        // stackable = false;
    }

    protected override Item GetOneNew()
    {
        return new Kamera();
    }

    // need to impliment this
    // protected override void initNetFields()
    // {
    //     base.initNetFields();
    //     // add fields here
    // }

    public override void resetState()
    {
        this.isTakingPhoto = false;

        // FishingRod.cs sets this to false, why?
        // I think this should be true?
        this.doneWithAnimation = false;
        this.hasDoneFucntionYet = false;
    }
}