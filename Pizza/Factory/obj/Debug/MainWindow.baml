   M S B A M L   `   `   `  ����I  EFactoryPattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FactoryPatternFactoryPattern  5   	       FactoryPattern.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FactoryPattern     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5   
   	� -   5         	�Name$ Ncheese��5      $
��Left=�6D   $��	47,50,0,0q�6_   $	��Top=�6r   $	��160��6�   $��0��6�   ��6'   �� *
Pizza[0]+��6�   �� *PizzaSelectCommand+6�   	� 5   
   -   5        $ Nclam��5      $
��Left=�6B   $��	47,80,0,0q�6]   $	��Top=�6p   $	��160��6�   $��1��6�   ��6%   �� *
Pizza[1]+��6�   �� *PizzaSelectCommand+6�   	� 5   
   -   5        $ Ccheese��5      $
��Left=�6D   $��
47,110,0,0q�6_   $	��Top=�6s   $	��160��6�   $��2��6�   ��6'   �� *
Pizza[2]+��6�   �� *PizzaSelectCommand+6�   	� 5   
   -   5        $ Cclam��5      $
��Left=�6B   $��
47,140,0,0q�6]   $	��Top=�6q   $	��160��6�   $��3��6�   ��6%   �� *
Pizza[3]+��6�   �� *PizzaSelectCommand+6�   �� 5   
   -   5         ��Name$	 Cut��5      $
��Left=�6>   $��
291,54,0,0q�6Y   $	��Top=�6m   $	��120��6�   ��6    �� *	Option[0]+��6�   �� *OptionCheckCommand+��6�   ��  �� RelativeSource �� *Self+�� 5   
   -   5         ��Name$ order��5      $��주문하기��6    $
��Left=�6/   $��189,179,0,0q�6J   $	��Top=�6_   $	��120��6w    J� RenderTransformOrigin$ 0.369,0.842&�6�   ��6�   �� *OrderCommand+6�   5      5      