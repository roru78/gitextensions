        public List<Patch> Patches { get; set; } = new List<Patch>();
            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, staged, out var header);
            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, staged, out var header);
            return GetPatchBytes(header, body, fileContentEncoding);
            Patches = patchProcessor.CreatePatchesFromString(text).ToList();
            foreach (Patch patchApply in Patches)
            string SubChunkToPatch(SubChunk subChunk, ref int addedCount, ref int removedCount, ref bool wereSelectedLines)
            {
                return subChunk.ToResetUnstagedLinesPatch(ref addedCount, ref removedCount, ref wereSelectedLines);
            }
            return ToPatch(SubChunkToPatch);
            string SubChunkToPatch(SubChunk subChunk, ref int addedCount, ref int removedCount, ref bool wereSelectedLines)
            }
            return ToPatch(SubChunkToPatch);