﻿namespace Snake_Projekt
{
    class CoordinateConverter
    {
        public float scale { get; private set; }

        private float xOffset;
        private float yOffset;

        private float frame = 20;

        private float TilesX;
        private float TilesY;

        public CoordinateConverter(float height, float width, int tilesX, int tilesY)
        {
            TilesX = tilesX;
            TilesY = tilesY;
            setDimentions(height, width);
        }

        public void setDimentions(float width, float height)
        {

            float scaleX = ((width - frame * 2) / TilesX);
            float scaleY = ((height - frame * 2) / TilesY);

            scale = scaleX;
            yOffset = (scaleY - scale) / 2 * TilesX;
            xOffset = 0;
            if (scaleY < scaleX)
            {
                scale = scaleY;
                xOffset = (scaleX - scale) / 2 * TilesY;
                yOffset = 0;
            }
        }

        public float toViewX(float x)
        {
            return (scale * x) + frame + xOffset;
        }

        public float toViewY(float y)
        {
            return (scale * y)+ frame + yOffset;
        }
    }
}