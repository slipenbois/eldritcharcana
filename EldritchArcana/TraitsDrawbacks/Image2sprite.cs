using System.IO;
using UnityEngine;

namespace EldritchArcana
{
    static class Image2Sprite
    {
        public static Sprite Create(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            var texture = new Texture2D(64, 64);
            texture.LoadImage(bytes);
            return Sprite.Create(texture, new Rect(0, 0, 64, 64), new Vector2(0, 0));
        }
    }
}
//xcopy /y "D:\SteamLibrary\steamapps\common\Pathfinder Kingmaker\pathfinder-mods-1.0.2.1\\EldritchArcana\Images_sprites" "D:\SteamLibrary\steamapps\common\Pathfinder Kingmaker\Mods\EldritchArcana\sprites"