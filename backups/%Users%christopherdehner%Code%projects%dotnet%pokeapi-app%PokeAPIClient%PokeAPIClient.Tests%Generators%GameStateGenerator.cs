Vim�UnDo� 7�b<s�>��K���]y}+Nq�c���(l      using RestClient;                             _�Ţ   
 _�                            ����                                                                                                                                                                                                                                                                                                                                                             _��7     �               8    public class GameStateGenerator : TheoryData<IState>5�_�                           ����                                                                                                                                                                                                                                                                                                                                                             _��K     �      
         #        public GameStateGenerator()5�_�                       "    ����                                                                                                                                                                                                                                                                                                                                                             _��R     �      	         #        public PokedexNameGenerator               ()5�_�                       #    ����                                                                                                                                                                                                                                                                                                                                                             _��S    �      	         &        public PokedexNameGenerator ()5�_�                       3    ����                                                                                                                                                                                                                                                                                                                                                             _��o     �               :    public class PokedexNameGenerator : TheoryData<IState>5�_�                    
       ����                                                                                                                                                                                                                                                                                                                                                             _��v     �   	   
          $            Add(new NewGameState());5�_�                    
       ����                                                                                                                                                                                                                                                                                                                                                             _��w     �   	   
          %            Add(new ContinueState());5�_�      	              
       ����                                                                                                                                                                                                                                                                                                                                                             _��x     �   	                        �   	          5�_�      
           	   
       ����                                                                                                                                                                                                                                                                                                                                                             _��     �   	   
                      foreach ()5�_�   	              
   
       ����                                                                                                                                                                                                                                                                                                                                                             _��     �   	                        �   	          5�_�   
                 
        ����                                                                                                                                                                                                                                                                                                                                                             _�Ě    �   	                        �   	          5�_�                       
    ����                                                                                                                                                                                                                                                                                                                                                             _�Ľ    �               namespace PokemonCLI.Tests5�_�                    
       ����                                                                                                                                                                                                                                                                                                                                                             _���     �   	            #            var pokeRepo = new Poke5�_�                    
   /    ����                                                                                                                                                                                                                                                                                                                                                             _���     �   	            /            var pokeRepo = new PokeRepository()5�_�                    
   .    ����                                                                                                                                                                                                                                                                                                                                                             _���     �   	            0            var pokeRepo = new PokeRepository();5�_�                      $    ����                                                                                                                                                                                                                                                                                                                                                             _���     �      	                 �      	       5�_�                       4    ����                                                                                                                                                                                                                                                                                                                                                             _��     �      	         5        private RestClient _client = new RestClient()�      	       5�_�                       Q    ����                                                                                                                                                                                                                                                                                                                                                             _��     �      	         Q        private RestClient _client = new RestClient("https://pokeapi.co/api/v2/")5�_�                           ����                                                                                                                                                                                                                                                                                                                                                             _��    �                �             5�_�                       !    ����                                                                                                                                                                                                                                                                                                                                                             _��2     �               !            List<string> names = 5�_�                           ����                                                                                                                                                                                                                                                                                                                                                             _��=    �                �             5�_�                       .    ����                                                                                                                                                                                                                                                                                                                                                             _��G    �               6            var pokeRepo = new PokeRepository(client);5�_�                       .    ����                                                                                                                                                                                                                                                                                                                                                             _��J   	 �                               �             �                           �             5�_�                            ����                                                                                                                                                                                                                                                                                                                                                             _�š   
 �               using RestClient;5�_�                       $    ����                                                                                                                                                                                                                                                                                                                                                             _���     �                5��