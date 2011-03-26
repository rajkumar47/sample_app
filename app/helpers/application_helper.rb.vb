module ApplicationHelper

	# -----------
	# Return title for each page
	def title
		base_title = "RoR"
		if @title.nil?
			base_title
		else
			"#{base_title} | #{@title}"
		end
	end

	# -------------
	# Return the logo
	def logo
      @logo_image = "logo.png"
      @alt = "Logo Image"
      
      tag = image_tag(@logo_image, :alt => @alt, :class => "round")
	  puts tag.to_s
	  return tag
	end
end
