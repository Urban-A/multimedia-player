   M S B A M L   `   `   `  ����N  JICRMultiMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ICRMultiMediaPlayerICRMultiMediaPlayer  5   	   $    ICRMultiMediaPlayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ICRMultiMediaPlayer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $��93��5	   	   $	��280��6   ���	#FF2C2C2C � 	Resources 5       �� 
TargetType   ListItemVideo �� Property �� Value �� Triggers �� Binding �� Path �� Value  ListItemVideoBackground	 P� Property
 P� Value �� RelativeSource �� Mode �� AncestorType��%C  &	        &	 o    �� 5   
   " ��6   .�5      ��  � �� �	#FF3030306+   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ Normal$�6*    5      �� 5       6   �� $ 	Predvajan� True6A   .a�5      ��  � �� �	#FF06060663   �� 5       � ��$
 Bold"�63   �� 5       � ��$ Normal$�62   5      5      �� 5   
   " ]�6   .�5      ��  � ��
 �����6+    5      P� 5      	 �@J�IsMouseOver
 . . �5      ��  � ��
 �����63   5      �� 5       5       ��  �� $ FindAncestor=�" ��$ 
IsSelected� True5!      .a�5"      ��  � �� �	#FFCBE8F663   5#      �� 5$       6   �� $ 	Predvajan� True6A   .a�5%      ��  � �� �	#FFCBCBCB63   5&      5(      5)      .��5+      ]� ��. .+�5-   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   ���	#FFF0F0F0.+�5.      o� .@�5/      m� $��Datoteka��6   .@�50      m� -   5        $��izhodBtn��50   .   $��Izhod��6   6W   m� 51      -   5        $��UvoziBtn��51   /   $��Uvozi��6   6X   m� 52      -   5        $��	IzvoziBtn��52   0   $��Izvozi��6   6[   53      m� 54      $��Seznam��6   .@�55      m� -   5        $��dodajBtn��55   .   $��Dodaj��6   6W   m� 56      -   5        $��odstraniBtn��56   1   $��Odstrani��6   6`   m� 57      -   5        $��urediBtn��57   /   $��Uredi��6   6X   58      m� 59      $��Orodja��6   .@�5:      m� -   5        $��nastavitveBtn��5:   3   $��
Nastavitve��6   6f   5;      5<      5=      )   #ICRMultiMediaPlayer.UserControlPlay  5?   
   -   5          Name$ playControls��5?   x   )   #ICRMultiMediaPlayer.UserControlPlay   Loaded$ playControls_Loaded��6�      Toggle TogglePlaylist6       PrevPl 
SelectPrev68      NextPl 
SelectNext6L   $��Bottom=�6`   6�   �� 5A   
   -	   5        $��playlist��5A   )   $
��Left=�6   $	��500��6�   $��50��6�   $y�Visible=�6�   ��5B      �� 5C      .R�5D      ]� #��[ 6    .+�5E      �� $	��160��69   $��90��6E   $
��Left=�6Q   $	��Top=�6g   $
��Left=�6   ��6    �� *Slika+6   �� 5F      $��Bottom=�6$   �� 5G      $��2q�6%   $ Vertical=�60   $��Right=�6G   .+�5H      �� #��[  6=   ��6(   �� *Pot+6=   �� 5I      $��Italic$�6X   ��6(   �� *Zvrst+ �� StringFormat$ 
Zvrst: {0}��6X   �� 5J      $	��200��6>   $
��Wrap=�6J   $
��Left=�6^   ��6(   �� *Opis+6^   �� 5K      ��6(   �� *DatumIzdaje+$ {0:MM/dd/yyyy}���� 5L      ��6(   �� *Ocena+$ Ocena: {0}/10��5N      5O      5P      5R      r� 5V   
   -
   5        $��mediaPlayer��5V   ,   $	��Top=�6    r� LoadedBehavior$ Manual=�6?   5W      5\      5]      