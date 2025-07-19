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

    public bool isTakingPhoto;

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
}