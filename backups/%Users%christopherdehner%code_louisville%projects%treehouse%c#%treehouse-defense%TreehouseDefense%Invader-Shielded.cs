Vim�UnDo� �	�	$������{�&��JC���@°���ⶉH                                      _��    _�                             ����                                                                                                                                                                                                                                                                                                                                                             _��     �                 �                 5�_�                    
        ����                                                                                                                                                                                                                                                                                                                                                             _��     �   	                     5�_�                    
        ����                                                                                                                                                                                                                                                                                                                                                             _��     �   	   
           5�_�                            ����                                                                                                                                                                                                                                                                                                                                                             _��    �                #    class ShieldedInvader : Invader       {   A        public override int Health { get; protected set; } = 100;   >        public override int Power { get; protected set; } = 0;   C        private static System.Random _random = new System.Random();   6        public ShieldedInvader(Path path) : base(path)   
        {}   7        public override void DecreaseHealth(int factor)   	        {   *            if (_random.NextDouble() < .5)               {   ,                base.DecreaseHealth(factor);               }     	        }       }5�_�                            ����                                                                                                                                                                                                                                                                                                                                                             _��*     �              5��