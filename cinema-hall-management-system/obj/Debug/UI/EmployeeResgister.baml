   M S B A M L   `   `   `  ����X  Tcinema-hall-management-system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:cinema_hall_management_system.UI cinema_hall_management_system.UI  5   	   8    2cinema_hall_management_system.UI.EmployeeResgister   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:cinema_hall_management_system.UI     5   	     � Title$  Employeee Registration��5   	   $	��750��6(   $	��800��65   .��5	      � .+�5
   
   �� $��Email��6   $
��Left=�6    $��
103,90,0,0q�6;   $	��Top=�6O   $��34��6g   $	��100��6s   �� 5   
   $��Password��6   $
��Left=�6#   $��103,145,0,0q�6>   $	��Top=�6S   $��34��6k   $	��100��6w   �� 5   
   $��Address��6   $
��Left=�6"   $��103,436,0,0q�6=   $	��Top=�6R   $��34��6j   $	��100��6v   �� 5   
   $��Date Of Birth��6   $
��Left=�6(   $��103,256,0,0q�6C   $	��Top=�6X   $��34��6p   $	��100��6|   �� 5   
   $��Gender��6   $
��Left=�6!   $��103,307,0,0q�6<   $	��Top=�6Q   $��34��6i   $	��100��6u    J� RenderTransformOrigin$ -1.526,3.031&�6�   �� 5   
   $
��Role��6   $
��Left=�6   $��103,366,0,0q�6:   $	��Top=�6O   $��34��6g   $	��100��6s   �� 5   
   $
��Name��6   $
��Left=�6   $��103,196,0,0q�6:   $	��Top=�6O   $��34��6g   $	��100��6s   �� 5   
   -   5         ��Name$ emailTextbox��5      $
��Left=�6(   $��34��6C   $��
295,90,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��375��6�   6�   G� 5   
   -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��295,145,0,0q�6F   $	��Top=�6[   $	��375��6s   $��34��6   �� 5   
   -   5        $ nameTextbox��5      $
��Left=�6'   $��34��6B   $��295,196,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��375��6�   6�   �� 5   
   -   5        $ roleTextbox��5      $
��Left=�6'   $��34��6B   $��295,366,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��375��6�   6�   �� 5   
   -   5        $ addressTextbox��5      $
��Left=�6*   $��34��6E   $��295,436,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��375��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePickerDOB��5         SelectedDate$ 
2000-12-31X�6,      SelectedDateFormat$
 Long=�6F   $
��Left=�6`   $��296,259,0,0q�6{   $	��Top=�6�   $	��374��6�   $��31��6�   �� 5   
   -   5         ��Name$ genderSelector��5      $
��Left=�6+   $��295,307,0,0q�6F   $	��Top=�6[   $	��375��6s   $��34��6   .@�5      �� 	 �� 
IsSelected	 . .��6.   Male64   �� 5      .��6   Female6#   5      �� 5   
   -   5        
 ��Name$
 registerButton��5      $��Register��6)   $
��Left=�6<   $��509,580,0,0q�6W   $	��Top=�6l   $	��161��6�   $��63��6�   6�   5       5!      