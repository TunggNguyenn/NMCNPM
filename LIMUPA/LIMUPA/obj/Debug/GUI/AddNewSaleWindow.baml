   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	   !    LIMUPA.GUI.AddNewSaleWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	     � Title$  AddNewSaleWindow��5       � WindowStyle$
 None=�6!    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�5	   	   $	��200��6   $	��320��6,   $��Segoe UI Emoji)�5
   	   $��1q�5   	   
���� ��.��5      � .+�5   
   �� $��30��6   $	��Top=�6    ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      .@�5      �� .��5      �� .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/info.png��6    	 �� BitmapScalingMode$	 HighQuality=�6:   �� 5      $��ADD NEW SALE��6$   
 �� TextAlignment$
 Center=�68   $��5,0,0,0q�6O   $
��Bold"�6`   5      5      5      �� 5      $��Right=�6   $��55��68   .��5      �� -   5         ��Name$ 
exitButton��5      
����  �$��24��6X   .��5      �� $��/Images/x-button.png��6   $	 HighQuality=�6:   5       5!      5"      �� 5#   
   -   5         ��Name$ validationLabel��5#      $��Center=�6)   $��16(�6M   $��0,35,0,0q�6[   $	��Top=�6m   $��Center=�6�   
���  ��$��Segoe UI Emoji)�6�   $
��Bold"�6�   ��5$      �� 5%      -   5         ��Name$ validationAccessText��5%       �� TextWrapping$
 Wrap=�6;   5'      �� 5(   
   $ Vertical=�6   $��Center=�6,   $��Bottom=�6J   .+�5)      �� $��0,0,10,0q�6   .��5*      �� $ 
Horizontal=�6   .+�5+      �� $��IMPORT DATE: ��6    $��Center=�65   $
 Center=�6P   
���  ��$
��Bold"�6x   (  "System.Windows.Controls.DatePicker  5,      -   5          Name$ importdateDatePicker��5,   !      Text$  ��6@   
����  �$��85��6[   $
��Bold"�6f   5-      5.      �� 5/      $��	0,0,10,70q�6   .��50      �� $ 
Horizontal=�6   .+�51      �� $
��TO: ��6    $��Center=�6,   $
 Center=�6G   
���  ��$
��Bold"�6o     52      -   5        $ nowdateDatePicker��52   !   $��62,0,0,0q�6<   $  ��6N   
����  �$��85��6i   $
��Bold"�6t   53      54      55      �� 56   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   .+�57      �� -   5        $ okButton��57      $��OK��6>   $��	0,0,10,30q�6K   $	��100��6^   �� 58      -   5        $ cancelButton��58      $��CANCEL��6F   $��	10,0,0,30q�6W   $	��100��6j   59      5:      5;      