   M S B A M L   `   `   `  ����E  ADesktopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DesktopApp.MVVM.ViewDesktopApp.MVVM.View  5   	   'clr-namespace:DesktopApp
DesktopApp  5   
   E'clr-namespace:DesktopApp.MVVM.ViewModelDesktopApp.MVVM.ViewModel  5	   	       DesktopApp.DataFormWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   +uc"clr-namespace:DesktopApp.MVVM.View  5   	   "uc1clr-namespace:DesktopApp  5   
   7	viewmodel'clr-namespace:DesktopApp.MVVM.ViewModel  5	   	     � Title$  DataFormWindow��5   	   $	��700��6    $
��1000��6-   
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � DataContext 5      1   +DesktopApp.MVVM.ViewModel.DataFormViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   �� ���#89cff0 �� Padding$ 30q�5       �� CornerRadius$ 	25 0 0 25��5       ._�5!      �� $��Center=�6   .+�5"      �� -   5         ��Name$ MyImage��5"      $	��160��6H   $	��160��6T   $��0 0 0 40q�6a   ��6)   �� *ImageSource+6a   �� 5#      $��Enter Student Details��6   	 �� TextAlignment$	 Center=�69   $��SemiBold"�6P   $��28(�6f   ���#3636366t   �� 5$         buttonBlack#��[  6   .��5%      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 
AngleRight=�6&   $��25��68   $��25��6C      
Foreground �#ffd500$��3 0 0 0q�6d   5'      5(      5)      �� 5.   
   -   5        $��1��5.      $ 20q�6!   ���#ffffff$ 	0 25 25 0��6C   ._�5/      � .+�50      �� $	��Top=�6   $��Right=�65    �� Orientation$ 
Horizontal=�51      .+�53      �� $��20��6   $��20��54      $	��✖��55      
������ $��0q�57      
�������$��0 0 10 0q�59      ��5:      �� *DataFormCloseCommand+5=      � 5?      $��Center=�6   $��Center=�64   $��0 10 0 0q�6O    5@      �� 5A      $	��150 �6+   �� 5B      $��* �6+    � RowDefinitions 5E      �� 5F      $
��auto �6(   �� 5G      $
��auto �6(   �� 5H      $
��auto �6(   �� 5I      $
��auto �6(   �� 5J      $
��auto �6(   �� 5K      $
��auto �6(   �� 5L      $
��auto �6(   �� 5M      $
��auto �6(   �� 5N      $
��auto �6(   .+�5Q      �� $��0��6    $��
Student ID��6-     text#��[ 6?   �� 5R      $��1��6    $��
First Name��6-   #��[ 6?   �� 5S      $��2��6    $��	Last Name��6-   #��[ 6>   �� 5T      $��3��6    $��Date of Birth��6-   #��[ 6B   �� 5U      $��4��6    $��
Department��6-   #��[ 6?   �� 5V      $��5��6    $
��Year��6-   #��[ 69   �� 5W      $��6��6    $	��GPA��6-   #��[ 68   �� 5X      $��7��6    $��Photo��6-   #��[ 6:   $   DesktopApp.MVVM.View.MyTextBox  5\      -   5          Name$ IdInput��5\   #   $��1��64   $��0��6D      HintText 6Q   �� *
HintIdIn+ �� Mode$ TwoWay=�   Text 6|   �� *IdIn+$ TwoWay=�  5^      -   5        $ 
fnameInput��5^   #   $��1��67   $��1��6G    6T   �� *HintFirstNameIn+$ TwoWay=� 6�   �� *FirstNameIn+$ TwoWay=�  5_      -   5        $ 
lnameInput��5_   #   $��1��67   $��2��6G    6T   �� *HintLastNameIn+$ TwoWay=� 6�   �� *
LastNameIn+$ TwoWay=�(  "System.Windows.Controls.DatePicker  5`      -   5          Name$ 	dateInput��5`   !   $��1��64   $��0 20 0 0q�6D   $��0q�6V   $��3��6j      Text 6w   �� *DOBIn+$ TwoWay=�  5d      -   5        $ dobInput��5d   #   $��0 0 30 0q�65   $��1��6H   $��3��6X    6e   �� *	HintDOBIn+$ TwoWay=� 6�   �� *DOBIn+$ TwoWay=�  5f      -   5        $ 	yearInput��5f   #   $��1��66   $��5��6F    6S   �� *
HintYearIn+$ TwoWay=� 6�   �� *YearIn+$ TwoWay=�  5g      -	   5        $ gpaInput��5g   #   $��1��65   $��6��6E    6R   �� *	HintGPAIn+$ TwoWay=� 6~   �� *GPAIn+$ TwoWay=��� 5h      -
   5         ��Name$ UploadButton��5h      $��Choose a file��63   $��1��6K   $��7��6[     
buttonMain#��[ 6h    � Cursor$
 Hand��6�   ��6�   �� *SelectImageCommand+��6�   ��  �� ElementName$ MyImage��6�   �� 5l      $ 
Horizontal=�6!   $��1��6:   $��4��6J   $
��0 10q�6W   .+�5n      �  5o      �� 5p   "   $
��auto �63   �� 5q   "   $
��auto �63   �� 5r   "   $
��auto �63   �� 5s   "   $
��auto �63   �� 5t   "   $
��auto �63   �� 5u   "   $
��auto �63    5w      �� 5x   "   $
��auto �60   �� 5y   "   $
��auto �60   .+�5|      	� $��Center=�6K   $��0��6h   $��0��6x     CircularRadioButtonStyle#��[ 6�   $��20 10 20 10q�5   *   $ Arrow��6?    d� 	IsChecked 5|   *   �� *
IsElecDept+��5~   "   �� *ElecDeptCommand+.��5�   "     $

 plug=�62   $��15��6>   $��15��6I   
 �����6U   5�      	� 5�      $��1��6J   $��0��6Z   #��[ 6g   $��20 10 20 10q�5�   *    5�   *   �� *	IsComDept+��5�   "   �� *ComDeptCommand+.��5�   "     $
 Laptop=�62   $��15��6@   $��15��6K   
 �����6W   5�      	� 5�      $��2��6M   $��0��6]   #��[ 6j   $��20 10 20 10q�5�   *    5�   *   �� *IsMarineDept+��5�   "   �� *MarineDeptCommand+.��5�   "     $
 Anchor=�62   $��15��6@   $��15��6K   
 �����6W   5�      	� 5�      $��3��6L   $��0��6\   #��[ 6i   $��20 10 20 10q�5�   *    5�   *   �� *IsMechaDept+��5�   "   �� *MechaDeptCommand+.��5�   "     $
 Wrench=�62   $��15��6@   $��15��6K   
 �����6W   5�      	� 5�      $��4��6L   $��0��6\   #��[ 6i   $��20 10 20 10q�5�   *    5�   *   �� *IsCivilDept+��5�   "   �� *CivilDeptCommand+.��5�   "     $

 User=�62   $��15��6>   $��15��6I   
 �����6U   5�      �� 5�      $��1��6(   $��0��65   $��
Electrical��6E   
���   �$��Center=�6j   $��SemiBold"�6�   $��Center=�6�   �� 5�      $��1��6(   $��1��65   $��Computer��6E   
���   �$��Center=�6h   $��SemiBold"�6�   $��Center=�6�   �� 5�      $��1��6(   $��2��65   $��Marine��6E   
���   �$��Center=�6f   $��SemiBold"�6�   $��Center=�6�   �� 5�      $��1��6(   $��3��65   $��
Mechanical��6E   
���   �$��Center=�6j   $��SemiBold"�6�   $��Center=�6�   �� 5�      $��1��6(   $��4��65   $��Civil��6E   
���   �$��Center=�6e   $��SemiBold"�6�   $��Center=�6�   5�      5�      � 5�      $��1��6   $��8��6+   $��0 40 0 0q�68    5�      �� 5�      $��* �6/   �� 5�      $��* �6/   .+�5�      �� $��Cancel��6!   $��0 0 10 0q�62   #��[ 6D   $
 Hand��6�   ��6i   �� *SaveCommand+6�   �� 5�      $
��Save��6!   $��10 0 0 0q�60   $��1��6B     buttonMainGreen#��[ 6R   $
 Hand��6�   ��6{   �� *SaveCommand+6�   5�      5�      5�      5�      5�      5�      