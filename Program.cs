using System;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory;
using System.Data;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            AbstractFactory factory = new MediaSocialFactory();
            var mediaSocial = factory.CreateMediaSocial();

            mediaSocial.Post(title:"Titulo do post"
            , body:"Minha primeira publicação no");
            mediaSocial.Like();
            
        }
    }
}
