module ApplicationHelper

	# Return title for each page
	def title
		base_title = "RoR"
		if @title.nil?
			base_title
		else
			"#{base_title} | #{@title}"
		end
	end
end
