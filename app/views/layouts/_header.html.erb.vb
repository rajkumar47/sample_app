<header>
	<%= link_to image_tag("logo.png", :alt => "Sample App", :class => 'round'), root_path %>
	<nav class="round">
		<ul>
			<li><%= link_to "Home", root_path %></li>
			<li><%= link_to "Help", help_path %></li>
			<li><%= link_to "Sign in", '#' %></li>
		</ul>
	</nav>
</header>
