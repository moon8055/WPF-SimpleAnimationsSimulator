   M S B A M L   `   `   `  ����K  GRusticSimulators, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RusticSimulatorsRusticSimulators  5      !    RusticSimulators.MeteorFall   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:RusticSimulators     5      -   5          N�Name$  Page1��5	       N� Title$ 
MeteorFall��6    N� 
Background 5
      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 0,1&�6/   .��5      �  � Color$ #0377fc��6    � Offset$ 0Q�6+   68   � 5      $ #54bbff��6   $	 0.5Q�6+   6:   � 5      $ 	AliceBlue��6   $ 1Q�6-   6:   5       � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   [�5      �� 5      .��5      �� .��5      �� 	 �� 
TargetName$	 Page1��6*   
 �� TargetProperty$S
 M(Page.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�5       �� From$ #0377fcX�5      	 �� To$ #AE0000X�6,    g� Duration$ 0:0:5D�69   �� 5      $	 Page1��6*   $S
 M(Page.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�5      $ #54bbffX�5      $ #E74723X�6,   $ 0:0:5D�69   �� 5      $	 Page1��6*   $S
 M(Page.Background).(LinearGradientBrush.GradientStops)[2].(GradientStop.Color)�5      $ 	AliceBlueX�5      $ #FF5656X�6.   $ 0:0:5D�6;   �� 5!       g� 	BeginTime$ 0:0:5X�6)   $	 Page1��6;   $S
 M(Page.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�5"      $ #AE0000X�5#      $ #460000X�6,   $ 0:0:2D�69    g� AutoReverse .  g� RepeatBehavior$ Forever��6]   �� 5$      $ 0:0:5X�6)   $	 Page1��6;   $S
 M(Page.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�5%      $ #E74723X�5&      $ #6A0000X�6,   $ 0:0:2D�69    . $ Forever��6]   �� 5'      $ 0:0:5X�6)   $	 Page1��6;   $S
 M(Page.Background).(LinearGradientBrush.GradientStops)[2].(GradientStop.Color)�5(      $ #FF5656X�5)      $ #960000X�6,   $ 0:0:2D�69    . $ Forever��6]   5*      5+      5-      .��5/      �� .+�50   
   �� $��town.png��6   $	��294��6"    �� Left$	 -87��6/   $
��1364��6A   
 �� Top$	 402��6N    51      :� 52      $ Loaded��6   [�53      �� 54      .��55      �� .��56   "   T� $ 0:0:5X�6@   $
 Source�6R   ..�57   &   i�  R� KeyTime$ 0:0:0��6=    R� Value 58   *   �� 59   .    �� 	UriSource$ town_reventado.png?�6:   5;   '   5<   #   5=      5>      5@      5B      �� 5C   
   -   5         ��Name$ meteor��5C   D   $��meteorRock.png��6   $��90��6(   $ 10��64   z�5D      T� 5E      -   5        bola��5E   5    5G      :� 5H      $ Loaded��6   .[�5I      �� .��5J      �� .��5K      U� $
	 bola��6<   $
 X�6Y   $ 0:0:5D�6w   .\�5L   "   ��  O� Value$	 250Q�67    O� KeyTime$ 0:0:2��6C   �� 5M   "   $	 550Q�67   $ 0:0:4��6C   �� 5N   "   $	 850Q�67   $ 0:0:5��6C   5O      U� 5P      $
	 bola��6<   $
 Y�6Y   $ 0:0:5D�6w   .\�5Q   "   �� $	 130Q�67   $ 0:0:2��6C   �� 5R   "   $	 340Q�67   $ 0:0:4��6C   �� 5S   "   $	 550Q�67   $ 0:0:5��6C   5T      T� 5U      $ 0:0:5X�6<   $
 Source�6N   ..�5V   "   i� $ 0:0:0��69    5W   &   �� 5X   *   $ explosion.png?�66   5Z   #   5[      U� 5\      $ 0:0:5X�6<   $
 Height�6N   .\�5]   "   �� $	 500Q�67   $ 0:0:0��6C   5^      U� 5_      $
	 bola��6<   $ 0:0:5X�6Y   $
 Y�6k   .\�5`   "   �� $	 200Q�67   $ 0:0:0��6C   5a      U� 5b      $
	 bola��6<   $ 0:0:5X�6Y   $
 X�6k   .\�5c   "   �� $	 650Q�67   $ 0:0:0��6C   5d      5e      5f      5g      5i      5j      5k      