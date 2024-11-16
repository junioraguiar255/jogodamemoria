using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProjetoJogoMemoria
{
    public class ImageManager
    {
        // Lista de imagens
        private static List<Bitmap> images = new List<Bitmap>();
        


        public ImageManager()
        {
            images.Clear();
            // Adicionar cada imagem à lista
            images.Add(Properties.Resources.Cat);
            images.Add(Properties.Resources.Dog);
            images.Add(Properties.Resources.Elephant);
            images.Add(Properties.Resources.Monkey);
            images.Add(Properties.Resources.Bull);

            images.Add(Properties.Resources.Horse);
            images.Add(Properties.Resources.Bear);
            images.Add(Properties.Resources.Spider);
            images.Add(Properties.Resources.Slow);
            images.Add(Properties.Resources.Bird);

            images.Add(Properties.Resources.Fish);
            images.Add(Properties.Resources.Rabbit);
            images.Add(Properties.Resources.Lion);
            images.Add(Properties.Resources.Zebra);
            images.Add(Properties.Resources.Duck);

            images.Add(Properties.Resources.Giraffe);
            images.Add(Properties.Resources.Tiger);
            images.Add(Properties.Resources.Christmas);
            images.Add(Properties.Resources.Cow);
            images.Add(Properties.Resources.Ganco);

            images.Add(Properties.Resources.Mouse);
            images.Add(Properties.Resources.Carnivore);
            images.Add(Properties.Resources.Teddy);
            images.Add(Properties.Resources.Cute);
            images.Add(Properties.Resources.Farm);

            images.Add(Properties.Resources.Rhino);
            images.Add(Properties.Resources.Pig);
            images.Add(Properties.Resources.Snike);
            images.Add(Properties.Resources.Fox);
            images.Add(Properties.Resources.Sapo);

            images.Add(Properties.Resources.Toucan);
            images.Add(Properties.Resources.Angry);


            List<string> animalNames = new List<string> { 
                "Cat", "Dog", "Elephant", "Monkey", "Bull",
                "Horse","Bear","Spider","Slow","Bird",
                "Fish","Rabbit","Lion","Zebra","Duck",
                "Giraffe","Tiger","Christmas","Cow","Ganco",
                "Mouse","Carnivore","Teddy","Cute","Farm",
                "Rhino","Pig","Snike","Fox","Sapo",
                "Toucan","Angry"};
            AssignTags(animalNames);

            // Adicione outras imagens conforme necessário
        }

        public List<Bitmap> GetImages()
        {
            return images;
        }

        public static void AssignTags(List<string> animalNames)
        {

            if (animalNames.Count != images.Count)
            {
                throw new ArgumentException("O número de nomes de animais não corresponde ao número de imagens.");
            }

            // Atribuir uma tag a cada imagem baseada no nome do animal
            for (int i = 0; i < images.Count; i++)
            {
                images[i].Tag = animalNames[i];
            }
        }
    }
}
