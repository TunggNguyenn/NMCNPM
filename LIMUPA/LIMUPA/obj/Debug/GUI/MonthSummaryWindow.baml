   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	   l hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null�rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization 5   	   �{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5	   	   #    LIMUPA.GUI.MonthSummaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	   �DVrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	   �DVC{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5	   	     � Title$  MonthSummary��5
   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�5   	   $	��600��6   $
��1000��6,   $��Segoe UI Emoji)�5   	   $��1q�5   	   
���� ��.��5      � .+�5   
   �� $��40��6   $	��Top=�6    ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      .@�5      �� .��5      �� .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/info.png��6    	 �� BitmapScalingMode$	 HighQuality=�6:   �� 5      $��MONTH SUMMARY��6$   $��20(�69   $��5,0,0,0q�6G   $
��Bold"�6X   5      5      5      �� 5      $��Right=�6   $��55��68   .��5       �� -   5        
 ��Name$
 
exitButton��5       
����  �$��34��6X   .��5!      �� $��/Images/x-button.png��6   $	 HighQuality=�6:   5"      5#      5$      � 5&   
   $	��Top=�6   $��0,40,0,0q�6'    � RowDefinitions 5'      �� 5(      $	��500 �6    �� 5)      $��* �6    .+�5,      �� $��0��6   $��Center=�6&   $��Center=�6A   .+�5-      >  8System.Windows.Controls.DataVisualization.Charting.Chart  -   5          Name$ monthsummaryChart��5-         Title$  ��67   
���  ��$
��Bold"�6Q   $	��450��6c   $	��700��6p   
����ح�
���  ��$��2q�6�   $	 HighQuality=�6�      Series 5/      C  =System.Windows.Controls.DataVisualization.Charting.LineSeries  -   5          Name$ captionChart��5/   )   ?  9System.Windows.Controls.DataVisualization.Charting.Series   Title$  ��6?   $	 HighQuality=�6H   H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6�      IndependentValueBinding 6v   ��  �� Path$	 Key�6�   51      52      �� 55      -   5        $
 okButton��55   P   $��1��6   $��Right=�6"   $��0,0,80,0q�6>   $��40��6y   $
��Bold"�6�   $	��200��6�   $��OK��6�   56      57      58      