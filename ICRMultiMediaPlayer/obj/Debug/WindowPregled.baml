   M S B A M L   `   `   `  ����N  JICRMultiMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ICRMultiMediaPlayerICRMultiMediaPlayer  5   	   O,clr-namespace:ICRMultiMediaPlayer.PropertiesICRMultiMediaPlayer.Properties  5   	   '    !ICRMultiMediaPlayer.WindowPregled   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ICRMultiMediaPlayer     5   	   :p,clr-namespace:ICRMultiMediaPlayer.Properties     5   	     � Title$  WindowPregled��5	   	   $	��309��6   $	��548��6,    � 
ResizeMode$ NoResize=�68   .��5
      ]� .+�5   
   �� $��Bottom=�6    �� Orientation$ 
Horizontal=�6-   $��RightToLeft=�6F   ���	#FFF0F0F0.+�5      �� -   5        $��shraniMediaBtn��5   p   $��OK��6   $	��1,0q�6"   ���	#FFF0F0F0$��1,1,3,1q�6^   ��6G   Z� 6�   �� 5      -   5        $��zavrniMediaBtn��5   a   $��Zavrni��6   $	��1,0q�6&   ���	#FFF0F0F0��6J   Z� 6w   5      � 5   
   $	��Top=�6    � ColumnDefinitions 5      �� 5      $	��350 �6#   �� 5      .+�5      �� $��0��6   $ Vertical=�6)   $��5q�6@   .+�5      �� $	��Pot��6   �� 5      $��28��6>   ��6   �� *Pot+ �� Mode$ OneWay=�6>   �� 5      $��Ocena��6   ]� 5      .+�5      �� $��0��6    $��0,0,5,0q�6)   $
��Left=�6:   �� 5      $��10��6    $��5,0,0,0q�6*   $��Right=�6;   �� 5      -   5        $��pregledOcena��5   �   $
��Left=�6    � Maximum$ 10Q�63    �� TickPlacement$ BottomRight=�6@    �� TickFrequency$	 0.5Q�6\    �� IsSnapToTickEnabled . 	 � Value	 6�   �� *Ocena+$ TwoWay=�
 �� UpdateSourceTrigger$
 Explicit=�6�   5      �� 5       $
��Opis��6   �� 5!      -   5        $��pregledOpis��5!   �    �� 	MaxLength$	 110��6[   $	��5,0q�6k   $��43��6x    �� TextWrapping$
 Wrap=�6�   ��6   �� *Opis+$ TwoWay=�$
 Explicit=�6�   �� 5#      $��Datum izdaje��6   (  "System.Windows.Controls.DatePicker  5$      -   5        $��pregledDatum��5$   �   $��5,0,0,0q�6m   $
��Left=�6~   $	��120��6�      SelectedDate 6   �� *DatumIzdaje+$ TwoWay=�$
 Explicit=�6�   5'      �� 5)      $	��Top=�6   $ Vertical=�6.   $��1��6E   .+�5*      �� $��Slika��6   �� 5+      -   5        $��slikaSelect��5+      $��90��6F   $	��160��6R   $
��Left=�6^   $��5,0,0,0q�6y   .��5,      �� -   5        $��pregledSlika��5,   �   $
��Left=�6g   ��6   �� *Slika+$ OneWay=�$
 PropertyChanged=�6�   5-      �� 5.      $��Zvrst��6   �� 5/      -   5        $��pregledZvrst��50   �   $
��Left=�6a   $��5,0,0,0q�6|   $	��120��6�    �� SelectedItem 5/      �� *Zvrst+$ TwoWay=�$
 Explicit=���50      �� -  'ICRMultiMediaPlayer.Properties.Settings   Default �� Source# Z  �� Path$ Zvrsti�6�   51      52      54      55      