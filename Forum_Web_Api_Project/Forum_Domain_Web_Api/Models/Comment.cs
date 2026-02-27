using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Forum.Models
{
    public class Comment
    {
        #region Properties
        // Identifiant unique du commentaire
        public int Id { get; set; }
        // Identifiant de l'auteur (Membre)
        public int MemberId { get; set; }
        public int PostId { get; set; }
        public virtual Member Member { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
        // Le texte du message (Contrainte : Éditer ses messages)
        public string Content { get; set; } = string.Empty;
        // Date de création pour le suivi du forum
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public IEnumerable<Like> Likes { get; set; } =[];
        public IEnumerable<Tag> Tags { get; set; } = [];
        // Flag pour le signalement (Contrainte : Signaler un message)
        public bool IsReported { get; set; }
        // Nom du modérateur (Contrainte : Mention "Editer par...")
        public string? EditedBy { get; set; }
        #endregion

        #region Builders
        public Comment()
        {

        } 
        #endregion


    }
}
